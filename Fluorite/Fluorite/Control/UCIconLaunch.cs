using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.Control
{
    class UCIconLaunch : Control.UCController
    {
        private String IconName = null;
        private String UserName = null;
        private int UserIndex = 0;

        public UCIconLaunch(int UserIndex, String UserName, String Name)
        {
            this.IconName = Name;
            this.UserName = UserName;
            this.UserIndex = UserIndex;
        }

        public Boolean Execute()
        {
            Boolean result = true;
            try
            {
                switch (this.IconName)
                {
                    case "picviewerIcon":
                        new View.PictureViewerUI(Application.StartupPath + @"\File System\").Show();
                        break;

                    case "movIcon":
                        new View.MediaPlayerUI().Show();
                        break;

                    case "notepadIcon":
                        new View.NotepadUI().Show();
                        break;

                    case "dataIcon":
                        if (!new Control.UCLogin(this.UserIndex, this.UserName).Execute())
                        {
                            MessageBox.Show("数据库错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "pluginIcon":
                        new View.AddValueUI().Show();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                result = false;
            }
            return result;
        }
    }
}
