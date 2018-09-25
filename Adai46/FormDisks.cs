﻿using System;
using System.IO;
using System.Collections;
using Bunifu.Framework.UI;

using System.Windows.Forms;

namespace Adai46
{
    public partial class FormDisks : Form
    {
        RomInfo rom = new RomInfo();

        public FormDisks()
        {
            InitializeComponent();
            SeacherInfo searcher = new SeacherInfo();
            DiskInfo(searcher.getrDrives());
        }

        private void DiskInfo(ArrayList drives)
        {
            int currentDisk = 0;


            foreach (RomInfo drive in drives){
                Panel panel = new Panel();
                panel.Name = "panel" + drive.NameOfParts;
                panel.Parent = pnBot;
                panel.Size = new System.Drawing.Size(711, 61);
                panel.Dock = DockStyle.Top;
                panel.BackColor = currentDisk % 2 == 0 ? System.Drawing.Color.Gainsboro: System.Drawing.Color.White;

                BunifuCircleProgressbar circle = new BunifuCircleProgressbar();
                circle.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
                circle.Parent = panel;
                circle.Location = new System.Drawing.Point(10, 12);
                circle.Size = new System.Drawing.Size(40, 40);
                circle.LabelVisible = false;
                circle.animated = true;
                circle.animationIterval = 1;
                circle.animationSpeed = 1;
                circle.ProgressColor = System.Drawing.Color.FromArgb(229, 126, 49);
                circle.BackColor = currentDisk % 2 == 0 ? System.Drawing.Color.Gainsboro : System.Drawing.Color.White;
                circle.Value = 30;
                circle.ProgressBackColor = System.Drawing.Color.DimGray;
                circle.LineProgressThickness = 5;
                circle.LineThickness = 1;
                panel.Controls.Add(circle);

                Label diskName = new Label();
                diskName.Name = "diskName";
                diskName.Text = drive.NameOfParts;
                diskName.Font = new System.Drawing.Font("Century Gothic", 10);
                diskName.Location = new System.Drawing.Point(94,24);
                panel.Controls.Add(diskName);
                pnBot.Controls.Add(panel);
                currentDisk++;

                Label diskUsedTotal = new Label();
                diskUsedTotal.Name = "diskUsedTotal";
                diskUsedTotal.Font = new System.Drawing.Font("Century Gothic", 10);
                diskUsedTotal.Text = Convert.ToString(BaytToGByte(drive.TotalSize) - 
                    BaytToGByte(drive.FreeSpace)) + "/" + 
                    Convert.ToString(BaytToGByte(drive.TotalSize)) + " GB";
                diskUsedTotal.Location = new System.Drawing.Point(290, 24);
                panel.Controls.Add(diskUsedTotal);
                pnBot.Controls.Add(panel);

                Label diskPersents = new Label();
                diskPersents.Name = "diskPersents";
                diskPersents.Font = new System.Drawing.Font("Century Gothic", 10);
                diskPersents.Text = Convert.ToString(MemoryUsedPersent(drive.TotalSize, drive.FreeSpace)) + " %";
                diskPersents.Location = new System.Drawing.Point(450, 24);
                panel.Controls.Add(diskPersents);
                pnBot.Controls.Add(panel);

                BunifuProgressBar lineProgressBar = new BunifuProgressBar();
                lineProgressBar.Value = MemoryUsedPersent(drive.TotalSize, drive.FreeSpace);
                lineProgressBar.Location = new System.Drawing.Point(550, 26);
                lineProgressBar.Size = new System.Drawing.Size(120, 7);
                lineProgressBar.ProgressColor = System.Drawing.Color.FromArgb(229, 126, 49);
                lineProgressBar.BackColor = System.Drawing.Color.FromArgb(31, 43, 55);

                panel.Controls.Add(lineProgressBar);
                pnBot.Controls.Add(panel);
            }

            panelMenu();
        }

        private void panelMenu()
        {
            Panel panelMenu = new Panel();
            panelMenu.Name = "panelMenu";
            panelMenu.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelMenu.Parent = pnBot;
            panelMenu.Size = new System.Drawing.Size(711, 61);
            panelMenu.Dock = DockStyle.Top;

            BunifuFlatButton buttonExplorer = new BunifuFlatButton();
            buttonExplorer.Name = "btOpenExplorer";
            buttonExplorer.Text = "Open";
            buttonExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            buttonExplorer.Location = new System.Drawing.Point(20, 12);
            buttonExplorer.IconVisible = false;
            buttonExplorer.Font = new System.Drawing.Font("Century Gothic", 10);
            buttonExplorer.BackColor = System.Drawing.Color.FromArgb(229, 126, 49);
            buttonExplorer.Normalcolor = System.Drawing.Color.FromArgb(229, 126, 49);
            buttonExplorer.OnHovercolor = System.Drawing.Color.FromArgb(31, 43, 55);
            buttonExplorer.OnHoverTextColor = System.Drawing.Color.FromArgb(229, 126, 49);
            buttonExplorer.Size = new System.Drawing.Size(91, 39);
            panelMenu.Controls.Add(buttonExplorer);
            pnBot.Controls.Add(panelMenu);

            BunifuElipse elipse = new BunifuElipse();
            elipse.ElipseRadius = 40;
            elipse.TargetControl = buttonExplorer;

            Label totalUserdMem = new Label();
            totalUserdMem.Name = "diskPersents";
            totalUserdMem.Text = "Used/Total";
            totalUserdMem.Location = new System.Drawing.Point(284, 24);
            totalUserdMem.Font = new System.Drawing.Font("Century Gothic", 10);
            panelMenu.Controls.Add(totalUserdMem);
            pnBot.Controls.Add(panelMenu);

        }

        private int MemoryUsedPersent(long totalByte, long freeByte)
        {
            int total = BaytToMByte(totalByte);
            int free = BaytToMByte(freeByte);
            int used = UsedMemoryMb(total, free);

            int freePersent = free / (total / 100);
            int usedPersent = 100 - freePersent;

            return usedPersent;
        }

        private int UsedMemoryMb(int total, int free)
        {
            return total - free;
        }
        
        private int BaytToGByte(long bayt)
        {
            long longGBayt = bayt / 1048576000;
            return Convert.ToInt32(longGBayt);
        }

        public int BaytToMByte(long bayt)
        {
            long longGBayt = bayt / 1048576;
            return Convert.ToInt32(longGBayt);
        }

        private void btOpenExplorer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe");
        }
        
        private void bunifuFlatButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe");
        }
    }
}
