namespace AppointmentApp.View;

public enum ConflictDecision
{
    Replace,
    ChangeTime,
    Cancel
}

public partial class ConflictDecisionDialog : Form
{
    public ConflictDecision Decision { get; private set; } = ConflictDecision.Cancel;

    public ConflictDecisionDialog()
    {
        InitializeComponent();
    }

    private void replaceButton_Click(object sender, EventArgs e)
    {
        Decision = ConflictDecision.Replace;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void changeTimeButton_Click(object sender, EventArgs e)
    {
        Decision = ConflictDecision.ChangeTime;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Decision = ConflictDecision.Cancel;
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
