/*
 * Created by SharpDevelop.
 * User: Tebjan Halm
 * Date: 21.01.2014
 * Time: 16:55
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TimerTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        private ContextMenu trayMenu;

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            //trayMenu.MenuItems.Add("Show Timer", OnShow);
            trayMenu.MenuItems.Add("Set Timer", SetTimerButtonClick);
            trayMenu.MenuItems.Add("Unset Timer", UnsetTimerClick);
            trayMenu.MenuItems.Add("Exit", OnExit);
                     
            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
         }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}
		
		private void DisplayTimerCaps()
		{
			var caps = WinApiCalls.QueryTimerResolution();
			CurrentLabel.Text = "Current: " + (caps.PeriodCurrent/10000.0) + " ms";
			MinLabel.Text = "Min: " + (caps.PeriodMin/10000.0) + " ms";
			MaxLabel.Text = "Max: " + (caps.PeriodMax/10000.0) + " ms";
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}
		
		void SetTimerButtonClick(object sender, EventArgs e)
		{
			WinApiCalls.SetTimerResolution((uint)(numericUpDown2.Value * 10000));
		}
		
		void UnsetTimerClick(object sender, EventArgs e)
		{
			WinApiCalls.SetTimerResolution(0, false);
		}

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        private void OnShow(object sender, EventArgs e)
        {
            if (Visible == false) {
                Visible = true; // Hide form window.
                this.WindowState = FormWindowState.Normal;
                ShowInTaskbar = false; // Remove from taskbar.
            } else {
                Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trayIcon.Visible == true) {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
