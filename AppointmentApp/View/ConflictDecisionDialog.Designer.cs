namespace AppointmentApp.View;

partial class ConflictDecisionDialog
{
    private System.ComponentModel.IContainer components = null;
    private Label messageLabel;
    private Button replaceButton;
    private Button changeTimeButton;
    private Button cancelButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        messageLabel = new Label();
        replaceButton = new Button();
        changeTimeButton = new Button();
        cancelButton = new Button();
        SuspendLayout();

        messageLabel.AutoSize = true;
        messageLabel.Location = new Point(16, 16);
        messageLabel.Name = "messageLabel";
        messageLabel.Size = new Size(233, 15);
        messageLabel.TabIndex = 0;
        messageLabel.Text = "Conflict found. Choose your next action.";

        replaceButton.Location = new Point(16, 45);
        replaceButton.Name = "replaceButton";
        replaceButton.Size = new Size(90, 27);
        replaceButton.TabIndex = 1;
        replaceButton.Text = "Replace";
        replaceButton.UseVisualStyleBackColor = true;
        replaceButton.Click += replaceButton_Click;

        changeTimeButton.Location = new Point(120, 45);
        changeTimeButton.Name = "changeTimeButton";
        changeTimeButton.Size = new Size(90, 27);
        changeTimeButton.TabIndex = 2;
        changeTimeButton.Text = "Change Time";
        changeTimeButton.UseVisualStyleBackColor = true;
        changeTimeButton.Click += changeTimeButton_Click;

        cancelButton.Location = new Point(224, 45);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(90, 27);
        cancelButton.TabIndex = 3;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(330, 90);
        Controls.Add(cancelButton);
        Controls.Add(changeTimeButton);
        Controls.Add(replaceButton);
        Controls.Add(messageLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ConflictDecisionDialog";
        Text = "Conflict";
        ResumeLayout(false);
        PerformLayout();
    }
}
