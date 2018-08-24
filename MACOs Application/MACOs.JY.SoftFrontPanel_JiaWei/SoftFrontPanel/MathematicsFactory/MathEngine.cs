using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace MACOs.JY.SoftFrontPanel
{
    public class MathEngine
    {
        #region Private Fields

        private List<int> _chList;
        private BindingList<MathLibraries> _tasks = new BindingList<MathLibraries>();
        private List<string> _measureItems = new List<string>();
        private List<string> _libraries = new List<string>();
        private Type[] _types;


        #endregion

        #region Public Properties
        /// <summary>
        /// 回传通道清单给GUI
        /// </summary>
        public List<int> ChannelList
        {
            get { return _chList; }
            set { _chList = value; }
        }
        /// <summary>
        /// 回传任务清单给GUI
        /// </summary>
        public BindingList<MathLibraries> MeasureTasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
        /// <summary>
        /// 回传支援项目清单给GUI
        /// </summary>
        public List<string> Items
        {
            get { return _measureItems; }
            set { _measureItems = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// 数学运算引擎，提供GUI资讯接口
        /// </summary>
        public MathEngine(DataGridView dgv,ContextMenuStrip menustrip, int[] chList)
        {

            //Create the total channel list for library usage
            _chList = new List<int>();
            for (int i = 0; i < chList.Length; i++)
            {
                _chList.Add(chList[i]);
            }

            //Parsing all the Enum Names for MathEngine usage
            _types = Assembly.GetAssembly(typeof(MathLibraries)).GetTypes().Where(myType => myType.IsEnum&&myType.Name=="TestItems").ToArray();

            for (int i = 0; i < _types.Length; i++)
            {
                string[] items = _types[i].GetEnumNames();
                for (int j = 0; j < items.Length; j++)
                {
                    _libraries.Add(_types[i].DeclaringType.Name);
                    _measureItems.Add(items[j]);
                }

            }

            //Add new columns and data source, then binding to the datagridview
            dgv.Columns.Add(new DataGridViewComboBoxColumn() { HeaderText = "ChannelNum", DataSource = ChannelList, DataPropertyName = "ChNum" });
            dgv.Columns.Add(new DataGridViewComboBoxColumn() { HeaderText = "Item", DataSource = _measureItems, DataPropertyName = "Item" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Result", DataPropertyName = "Result" });


            dgv.DataSource = _tasks;
            dgv.Invalidate();


        }

        #endregion

        #region Methods
        /// <summary>
        /// 添加分析任务（呼叫工厂创建方法）
        /// </summary>
        public void AddTask(int ch, string item, object augment = null)
        {
            string lib = _libraries[_measureItems.FindIndex(x => x == item)];
            _tasks.Add(MathEngineFactory.CreateTask(ch, item, lib));
        }
        /// <summary>
        /// 移除指定任务
        /// </summary>
        public void RemoveTask(int index)
        {
            _tasks.RemoveAt(index);
        }
        /// <summary>
        /// 清除任务
        /// </summary>
        public void ClearTask()
        {
            _tasks.Clear();
        }
        /// <summary>
        /// 运算开始（Parallel+Lock)
        /// </summary>
        public void Process()
        {
            object obj = new object();

            Action[] processitems = new Action[_tasks.Count];
            for (int i = 0; i < _tasks.Count; i++)
            {
                processitems[i] = _tasks.ElementAt(i).Process;
            }
            Parallel.Invoke(processitems);

        }
        /// <summary>
        /// 重新配置任务（呼叫工厂创建后取代任务清单）
        /// </summary>
        public void ReconfigTask(int taskIndex, int ch, string item, object augment = null)
        {
            _tasks.RemoveAt(taskIndex);
            int channel = _chList.IndexOf(ch);
            string lib = _libraries[_measureItems.FindIndex(x => x == item)];
            _tasks.Insert(taskIndex, MathEngineFactory.CreateTask(ch, item, lib));
        }
        /// <summary>
        /// 分割二维数组
        /// </summary>
        public void WfmSubset(double[,] rawData, List<int> chList, double sampleRate)
        {
            Parallel.ForEach(_tasks, item =>
            {
                item.SubsetData(rawData, chList.IndexOf(item.ChNum), sampleRate);
            });
        }

        /// <summary>
        /// 选用通道改变后，更新任务选单给GUI
        /// </summary>
        public void UpdateTasks(int channel, bool enabled, DataGridView dgv)
        {
            List<MathLibraries> tasks = _tasks.ToList();
            int loop = _tasks.Count;
            int index = 0;

            if (enabled)
            {
                if (!_chList.Exists(x => x == channel))
                {
                    _chList.Add(channel);
                    _chList.Sort();

                }
            }
            else
            {

                for (int i = 0; i < loop; i++)
                {
                    if (_tasks.ElementAt(i - index).ChNum == channel)
                    {
                        _tasks.RemoveAt(i - index);
                        index++;
                    }
                }
                _chList.Remove(channel);

            }
            dgv.Columns.RemoveAt(0);
            dgv.Columns.Insert(0, new DataGridViewComboBoxColumn() { Name = "ChannelNum", DataSource = ChannelList, DataPropertyName = "ChNum" });
            dgv.DataSource = _tasks;

        }

        #endregion


    }

}
