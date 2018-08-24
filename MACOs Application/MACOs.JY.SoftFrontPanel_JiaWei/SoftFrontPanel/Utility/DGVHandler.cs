using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;

/// <summary>
/// 修改日期：2017.06.24
/// 作者：简仪科技
/// 描述：使用DataGridView作为基础，利用定制类作为columns和row的布局。
/// </summary>
namespace MACOs.JY.SoftFrontPanel
{
    public class DGVGUIHandler
    {
        #region private fields

        private DataGridView _dgv;
        private BindingList<object> _objlist;

        /// <summary>
        /// Activated when the datagridview cell value is changed
        /// </summary>
        public delegate void CellEventHandler(object sender, CellValueChangedEventArgs e);

        #endregion private fields

        #region Constructor

        public DGVGUIHandler()
        {
        }

        #endregion Constructor

        #region public properties

        /// <summary>
        /// Get the list of objects
        /// </summary>
        public BindingList<object> Data
        {
            get { return _objlist; }
        }

        #endregion public properties

        #region Public Methods

        /// <summary>
        /// Bind the datagridview with the List of objects
        /// </summary>
        public void BindingSource(DataGridView dgv, BindingList<object> objList)
        {
            _dgv = dgv;
            _objlist = objList;
            if (objList.Count > 0)
            {
                GUIInitialize();

                Type t = _objlist.ToArray()[0].GetType();
                PropertyInfo[] props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                MethodInfo method = t.GetMethod("GetDataSource", BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo prop in props)
                {
                    if (method != null)
                    {
                        object list = method.Invoke(_objlist.ToArray()[0], new object[] { prop.Name });
                        if (list != null)
                        {
                            InitializeColumns(prop, list);
                        }
                        else
                        {
                            InitializeColumns(prop, null);
                        }
                    }
                    else
                    {
                        InitializeColumns(prop, null);
                    }
                }
                _dgv.DataSource = _objlist;
                _dgv.Invalidate();
            }
        }

        public void UpdateColumnList(int index)
        {
        }

        #endregion Public Methods

        #region Private Methods

        private void GetColumnList(int index)
        {
        }

        /// <summary>
        /// Configure the columns based on the properties of objects
        /// </summary>
        private void InitializeColumns(PropertyInfo prop, object list)
        {
            if (list != null)
            {
                DataGridViewComboBoxColumn colComBox = new DataGridViewComboBoxColumn();
                colComBox.ValueType = (prop.PropertyType);
                colComBox.HeaderText = prop.Name;
                colComBox.Name = prop.Name;
                colComBox.DataSource = list;
                colComBox.DataPropertyName = prop.Name;
                _dgv.Columns.Add(colComBox);
            }
            else
            {
                if (prop.PropertyType.IsEnum)
                {
                    DataGridViewComboBoxColumn colComBox = new DataGridViewComboBoxColumn();
                    colComBox.HeaderText = prop.Name;
                    colComBox.Name = prop.Name;
                    colComBox.DataSource = Enum.GetValues(prop.PropertyType);
                    colComBox.DataPropertyName = prop.Name;
                    _dgv.Columns.Add(colComBox);
                }
                else
                {
                    if (prop.PropertyType.Name == "Boolean")
                    {
                        DataGridViewCheckBoxColumn colCheckBox = new DataGridViewCheckBoxColumn();
                        colCheckBox.HeaderText = prop.Name;
                        colCheckBox.DataPropertyName = prop.Name;
                        _dgv.Columns.Add(colCheckBox);
                    }
                    else
                    {
                        DataGridViewTextBoxColumn colTextBox = new DataGridViewTextBoxColumn();
                        colTextBox.HeaderText = prop.Name;
                        colTextBox.DataPropertyName = prop.Name;
                        _dgv.Columns.Add(colTextBox);
                    }
                }
            }
        }

        /// <summary>
        /// Initial configuration of the datagridview and register the events
        /// </summary>
        private void GUIInitialize()
        {
            #region Configure the properties of the DGV

            _dgv.AllowUserToAddRows = false;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ScrollBars = ScrollBars.Both;
            _dgv.AllowUserToOrderColumns = false;
            _dgv.ShowEditingIcon = false;

            #endregion Configure the properties of the DGV

            #region Register the Events of the DGV

            _dgv.CurrentCellDirtyStateChanged -= _dgv_CurrentCellDirtyStateChanged;
            _dgv.CellValueChanged -= _dgv_CellValueChanged;

            _dgv.CurrentCellDirtyStateChanged += _dgv_CurrentCellDirtyStateChanged;
            _dgv.CellValueChanged += _dgv_CellValueChanged;

            #endregion Register the Events of the DGV
        }

        #endregion Private Methods

        #region Registered Events from GUI

        /// <summary>
        /// Registered Event from GUI (valueChanged)
        /// </summary>
        private void _dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CellValueChangedEvent != null)
            {
                CellValueChangedEventArgs args = new CellValueChangedEventArgs(((DataGridView)sender).Rows[e.RowIndex].DataBoundItem, e.RowIndex, e.ColumnIndex);
                CellValueChangedEvent(sender, args);
            }
        }

        /// <summary>
        /// Registered Event from GUI (valueChanged)
        /// </summary>
        private void _dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            _dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion Registered Events from GUI

        #region Exported Event Arguments

        /// <summary>
        /// CellValueChangedEvent for programmer to use
        /// </summary>
        public event CellEventHandler CellValueChangedEvent;

        public class CellValueChangedEventArgs : EventArgs
        {
            private object rowData;
            private int rowIndex;
            private int columnIndex;

            /// <summary>
            /// Send back three paramters (colIndex, rowIndex, rowData)
            /// </summary>
            public CellValueChangedEventArgs(object data, int rowIndex, int colIndex)
            {
                this.rowData = data;
                this.rowIndex = rowIndex;
                this.columnIndex = colIndex;
            }

            /// <summary>
            /// Current row data of the selected cell
            /// </summary>
            public object SelectedRowData
            {
                get { return rowData; }
            }

            /// <summary>
            /// Current row index of the selected cell
            /// </summary>
            public int SelectedRowIndex
            {
                get { return rowIndex; }
            }

            /// <summary>
            /// Current column index of the selected cell
            /// </summary>
            public object SelectedColumnIndex
            {
                get { return columnIndex; }
            }
        }

        #endregion Exported Event Arguments
    }

    public class DGVLookUpTable
    {
        private Dictionary<string, object> dict;

        public DGVLookUpTable()
        {
            dict = new Dictionary<string, object>();
        }

        /// <summary>
        /// Add new look up table for library to search (if item is not found, use default setting)
        /// </summary>
        public void ConfigureLUT(string key, object value)
        {
            object result;
            if (dict.TryGetValue(key, out result))
            {
                //key is already existed
                dict.Remove(key);
            }
            dict.Add(key, value);
        }

        /// <summary>
        /// Search the data using look up table
        /// </summary>
        public object GetDataSource(string name)
        {
            object result;
            bool isFound = dict.TryGetValue(name, out result);
            return isFound ? result : null;
        }
    }
}