using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace EasyDAQ
{
    internal partial class TriggerConfigurator : Form
    {
        private List<object> objectPool = new List<object>();

        private int levelNum = 0;
        private string propName;
        private object nxtLevel;
        private object instance;

        public TriggerConfigurator(object triggerObj)
        {
            InitializeComponent();
            objectPool.Clear();
            instance = CopyNewInstance(triggerObj);
            objectPool.Add(instance);
            propertyGrid1.SelectedObject = objectPool[0];
            textBox1.Text = objectPool[0].GetType().FullName;
            easyButton_prevLevel.Enabled = false;
            easyButton_nextLevel.Enabled = false;
        }

        public static object EditValue(object triggerObj)
        {
            TriggerConfigurator form = new TriggerConfigurator(triggerObj);
            form.ShowDialog();
            return form.objectPool[0];
        }

        private void easyButton_prevLevel_Click(object sender, EventArgs e)
        {
            objectPool.RemoveAt(levelNum);
            levelNum--;
            propertyGrid1.SelectedObject = objectPool[levelNum];
            textBox1.Text = objectPool[levelNum].GetType().ToString();
        }

        private void easyButton_nextLevel_Click(object sender, EventArgs e)
        {
            objectPool.Add(nxtLevel);
            levelNum++;
            propertyGrid1.SelectedObject = objectPool[levelNum];
            textBox1.Text = objectPool[levelNum].GetType().FullName;
        }

        private void easyButton_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            propName = propertyGrid1.SelectedGridItem.Label;
            nxtLevel = objectPool[levelNum].GetType().GetProperty(propName).GetValue(objectPool[levelNum], null);
            easyButton_nextLevel.Enabled = nxtLevel.GetType().IsClass && !nxtLevel.GetType().IsEnum;
            easyButton_prevLevel.Enabled = levelNum != 0;
        }

        private object CopyNewInstance(object src)
        {
            //    MemberInfo[] mi = src.GetType().GetMembers();
            //    ConstructorInfo ci = Array.Find(mi, x => x.MemberType == MemberTypes.Constructor) as ConstructorInfo;
            //    ParameterInfo[] pi = ci.GetParameters();
            //    object[] param = new object[pi.Length];
            //    for (int i = 0; i < param.Length; i++)
            //    {
            //        param[i] = pi[i].DefaultValue;
            //    }
            //    object reference = Activator.CreateInstance(src.GetType(), param);
            //    PropertyInfo[] props = reference.GetType().GetProperties();
            //    for (int i = 0; i < props.Length; i++)
            //    {
            //        if (props[i].CanWrite&&props[i].CanRead)
            //        {
            //            props[i].SetValue(reference, props[i].GetValue(src, null), null);
            //        }
            //    }


            //    return reference;

            return src;
        }

}
}