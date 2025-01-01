namespace SprayProcessSystem.UI.Views
{
    partial class ViewTotalControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTotalControl));
            button1 = new AntdUI.Button();
            panel_stationControl = new AntdUI.Panel();
            flowPanel2 = new AntdUI.FlowPanel();
            stationTotalControl6 = new UserControls.StationTotalControl();
            stationTotalControl4 = new UserControls.StationTotalControl();
            stationTotalControl3 = new UserControls.StationTotalControl();
            stationTotalControl5 = new UserControls.StationTotalControl();
            flowPanel1 = new AntdUI.FlowPanel();
            stationTotalControl8 = new UserControls.StationTotalControl();
            stationTotalControl7 = new UserControls.StationTotalControl();
            stationTotalControl1 = new UserControls.StationTotalControl();
            stationTotalControl2 = new UserControls.StationTotalControl();
            panel2 = new AntdUI.Panel();
            flowPanel3 = new AntdUI.FlowPanel();
            button5 = new AntdUI.Button();
            button4 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            txt_log = new AntdUI.Input();
            panel_stationControl.SuspendLayout();
            flowPanel2.SuspendLayout();
            flowPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.IconRatio = 1F;
            button1.IconSvg = resources.GetString("button1.IconSvg");
            button1.Location = new Point(92, 3);
            button1.Name = "button1";
            button1.Size = new Size(101, 52);
            button1.TabIndex = 3;
            button1.Text = "总启动";
            button1.Type = AntdUI.TTypeMini.Success;
            button1.WaveSize = 1;
            button1.Click += buttonControl_Click;
            // 
            // panel_stationControl
            // 
            panel_stationControl.Back = Color.WhiteSmoke;
            panel_stationControl.BackColor = Color.White;
            panel_stationControl.Controls.Add(flowPanel2);
            panel_stationControl.Controls.Add(flowPanel1);
            panel_stationControl.Dock = DockStyle.Top;
            panel_stationControl.Location = new Point(0, 66);
            panel_stationControl.Name = "panel_stationControl";
            panel_stationControl.Shadow = 4;
            panel_stationControl.ShadowOpacityAnimation = true;
            panel_stationControl.Size = new Size(827, 129);
            panel_stationControl.TabIndex = 3;
            panel_stationControl.Text = "panel1";
            // 
            // flowPanel2
            // 
            flowPanel2.Align = AntdUI.TAlignFlow.Center;
            flowPanel2.BackColor = Color.Transparent;
            flowPanel2.Controls.Add(stationTotalControl6);
            flowPanel2.Controls.Add(stationTotalControl4);
            flowPanel2.Controls.Add(stationTotalControl3);
            flowPanel2.Controls.Add(stationTotalControl5);
            flowPanel2.Dock = DockStyle.Top;
            flowPanel2.Gap = 12;
            flowPanel2.Location = new Point(5, 66);
            flowPanel2.Margin = new Padding(0);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(817, 61);
            flowPanel2.TabIndex = 6;
            flowPanel2.Text = "flowPanel2";
            // 
            // stationTotalControl6
            // 
            stationTotalControl6.IsTurnOn = false;
            stationTotalControl6.Location = new Point(590, 3);
            stationTotalControl6.Name = "stationTotalControl6";
            stationTotalControl6.Size = new Size(150, 45);
            stationTotalControl6.StationName = "输送机工位";
            stationTotalControl6.TabIndex = 6;
            stationTotalControl6.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl4
            // 
            stationTotalControl4.IsTurnOn = false;
            stationTotalControl4.Location = new Point(419, 3);
            stationTotalControl4.Name = "stationTotalControl4";
            stationTotalControl4.Size = new Size(150, 45);
            stationTotalControl4.StationName = "固化炉工位";
            stationTotalControl4.TabIndex = 5;
            stationTotalControl4.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl3
            // 
            stationTotalControl3.IsTurnOn = false;
            stationTotalControl3.Location = new Point(248, 3);
            stationTotalControl3.Name = "stationTotalControl3";
            stationTotalControl3.Size = new Size(150, 45);
            stationTotalControl3.StationName = "冷却室工位";
            stationTotalControl3.TabIndex = 4;
            stationTotalControl3.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl5
            // 
            stationTotalControl5.IsTurnOn = false;
            stationTotalControl5.Location = new Point(77, 3);
            stationTotalControl5.Name = "stationTotalControl5";
            stationTotalControl5.Size = new Size(150, 45);
            stationTotalControl5.StationName = "水分炉工位";
            stationTotalControl5.TabIndex = 3;
            stationTotalControl5.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.Center;
            flowPanel1.BackColor = Color.Transparent;
            flowPanel1.Controls.Add(stationTotalControl8);
            flowPanel1.Controls.Add(stationTotalControl7);
            flowPanel1.Controls.Add(stationTotalControl1);
            flowPanel1.Controls.Add(stationTotalControl2);
            flowPanel1.Dock = DockStyle.Top;
            flowPanel1.Gap = 10;
            flowPanel1.Location = new Point(5, 5);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(817, 61);
            flowPanel1.TabIndex = 5;
            flowPanel1.Text = "flowPanel1";
            // 
            // stationTotalControl8
            // 
            stationTotalControl8.IsTurnOn = false;
            stationTotalControl8.Location = new Point(587, 3);
            stationTotalControl8.Name = "stationTotalControl8";
            stationTotalControl8.Size = new Size(150, 45);
            stationTotalControl8.StationName = "精洗工位";
            stationTotalControl8.TabIndex = 6;
            stationTotalControl8.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl7
            // 
            stationTotalControl7.IsTurnOn = false;
            stationTotalControl7.Location = new Point(418, 3);
            stationTotalControl7.Name = "stationTotalControl7";
            stationTotalControl7.Size = new Size(150, 45);
            stationTotalControl7.StationName = "陶化工位";
            stationTotalControl7.TabIndex = 5;
            stationTotalControl7.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl1
            // 
            stationTotalControl1.IsTurnOn = false;
            stationTotalControl1.Location = new Point(249, 3);
            stationTotalControl1.Name = "stationTotalControl1";
            stationTotalControl1.Size = new Size(150, 45);
            stationTotalControl1.StationName = "粗洗工位";
            stationTotalControl1.TabIndex = 4;
            stationTotalControl1.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // stationTotalControl2
            // 
            stationTotalControl2.IsTurnOn = false;
            stationTotalControl2.Location = new Point(80, 3);
            stationTotalControl2.Name = "stationTotalControl2";
            stationTotalControl2.Size = new Size(150, 45);
            stationTotalControl2.StationName = "脱脂工位";
            stationTotalControl2.TabIndex = 7;
            stationTotalControl2.SwitchStatusEvent += stationTotalControl_SwitchStatusEvent;
            // 
            // panel2
            // 
            panel2.Back = Color.WhiteSmoke;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Shadow = 4;
            panel2.ShadowOpacityAnimation = true;
            panel2.Size = new Size(827, 66);
            panel2.TabIndex = 10;
            panel2.Text = "panel2";
            // 
            // flowPanel3
            // 
            flowPanel3.Align = AntdUI.TAlignFlow.Center;
            flowPanel3.BackColor = Color.Transparent;
            flowPanel3.Controls.Add(button5);
            flowPanel3.Controls.Add(button4);
            flowPanel3.Controls.Add(button3);
            flowPanel3.Controls.Add(button2);
            flowPanel3.Controls.Add(button1);
            flowPanel3.Dock = DockStyle.Fill;
            flowPanel3.Gap = 20;
            flowPanel3.Location = new Point(5, 5);
            flowPanel3.Name = "flowPanel3";
            flowPanel3.Size = new Size(817, 56);
            flowPanel3.TabIndex = 5;
            flowPanel3.Text = "flowPanel3";
            // 
            // button5
            // 
            button5.IconRatio = 1F;
            button5.IconSvg = resources.GetString("button5.IconSvg");
            button5.IconToggleAnimation = 100;
            button5.Location = new Point(624, 3);
            button5.Name = "button5";
            button5.Size = new Size(101, 52);
            button5.TabIndex = 7;
            button5.Text = "空运行";
            button5.ToggleIconSvg = resources.GetString("button5.ToggleIconSvg");
            button5.ToggleType = AntdUI.TTypeMini.Primary;
            button5.WaveSize = 1;
            button5.Click += buttonControl_Click;
            // 
            // button4
            // 
            button4.IconRatio = 1F;
            button4.IconSvg = resources.GetString("button4.IconSvg");
            button4.Location = new Point(491, 3);
            button4.Name = "button4";
            button4.Size = new Size(101, 52);
            button4.TabIndex = 6;
            button4.Text = "报警复位";
            button4.Type = AntdUI.TTypeMini.Warn;
            button4.WaveSize = 1;
            button4.Click += buttonControl_Click;
            // 
            // button3
            // 
            button3.IconRatio = 1F;
            button3.IconSvg = resources.GetString("button3.IconSvg");
            button3.Location = new Point(358, 3);
            button3.Name = "button3";
            button3.Size = new Size(101, 52);
            button3.TabIndex = 5;
            button3.Text = "机械复位";
            button3.Type = AntdUI.TTypeMini.Warn;
            button3.WaveSize = 1;
            button3.Click += buttonControl_Click;
            // 
            // button2
            // 
            button2.IconRatio = 1F;
            button2.IconSvg = resources.GetString("button2.IconSvg");
            button2.Location = new Point(225, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 52);
            button2.TabIndex = 4;
            button2.Text = "总停止";
            button2.Type = AntdUI.TTypeMini.Error;
            button2.WaveSize = 1;
            button2.Click += buttonControl_Click;
            // 
            // txt_log
            // 
            txt_log.AutoScroll = true;
            txt_log.Dock = DockStyle.Fill;
            txt_log.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_log.Location = new Point(0, 195);
            txt_log.Multiline = true;
            txt_log.Name = "txt_log";
            txt_log.Size = new Size(827, 405);
            txt_log.TabIndex = 11;
            // 
            // ViewTotalControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txt_log);
            Controls.Add(panel_stationControl);
            Controls.Add(panel2);
            Name = "ViewTotalControl";
            Size = new Size(827, 600);
            panel_stationControl.ResumeLayout(false);
            flowPanel2.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Button button1;
        private AntdUI.Panel panel_stationControl;
        private AntdUI.Panel panel2;
        private AntdUI.Input txt_log;
        private AntdUI.FlowPanel flowPanel2;
        private UserControls.StationTotalControl stationTotalControl5;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button2;
        private UserControls.StationTotalControl stationTotalControl6;
        private UserControls.StationTotalControl stationTotalControl4;
        private UserControls.StationTotalControl stationTotalControl3;
        private UserControls.StationTotalControl stationTotalControl8;
        private UserControls.StationTotalControl stationTotalControl7;
        private UserControls.StationTotalControl stationTotalControl1;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button button5;
        private AntdUI.Button button4;
        private AntdUI.Button button3;
        private UserControls.StationTotalControl stationTotalControl2;
    }
}
