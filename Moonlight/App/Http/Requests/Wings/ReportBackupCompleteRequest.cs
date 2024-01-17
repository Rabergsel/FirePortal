namespace FirePortal.App.Http.Requests.Wings;

public class ReportBackupCompleteRequest
{
    public bool Successful { get; set; }
    public long Size { get; set; }
}