using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelWithDynamicControls
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{

			var pnlMetaDataControls = new Panel();
			pnlMetaDataControls.Location = new System.Drawing.Point(24, 66);
			pnlMetaDataControls.Name = "pnlMetaDataControls";
			pnlMetaDataControls.Size = new System.Drawing.Size(271, 132);
			pnlMetaDataControls.TabIndex = 0;
			this.Controls.Add(pnlMetaDataControls);
			for (int j = 0; j < int.Parse(textBox1.Text); j++)
			{
				DrawControls(pnlMetaDataControls);
			}
		}

		public void DrawControls(Panel pnlMetaDataControls)
		{
			ReCreateProfileFieldsPanel(pnlMetaDataControls);


			TextBox fldDisplay = new TextBox();
			fldDisplay.Name = "txt1";
			fldDisplay.Visible = true;
			fldDisplay.Enabled = true;
			pnlMetaDataControls.Controls.Add(fldDisplay);
		}

		//Clearning the controls in the panel.
		public void ReCreateProfileFieldsPanel(Panel pnlMetaDataControls)
		{
			foreach (Control control in pnlMetaDataControls.Controls)
			{
				var txtBoxControl = control as TextBox;
				pnlMetaDataControls.Controls.Remove(control);
				control.Dispose();
			}
			this.Controls.Remove(pnlMetaDataControls);
			pnlMetaDataControls.Dispose();
			

			pnlMetaDataControls = new Panel();
			pnlMetaDataControls.AutoScroll = true;
			pnlMetaDataControls.AutoSize = true;
			pnlMetaDataControls.BackColor = System.Drawing.Color.White;
			pnlMetaDataControls.Dock = System.Windows.Forms.DockStyle.Fill;
			pnlMetaDataControls.Location = new System.Drawing.Point(0, 0);
			pnlMetaDataControls.Name = "pnlMetaDataControls";
			pnlMetaDataControls.Size = new System.Drawing.Size(0, 0);
			pnlMetaDataControls.TabIndex = 15;
			this.Controls.Add(pnlMetaDataControls);
		}

	}
}
