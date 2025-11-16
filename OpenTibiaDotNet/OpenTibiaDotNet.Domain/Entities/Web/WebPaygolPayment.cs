namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebPaygolPayment
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int Price { get; set; }
    public int Points { get; set; }

    public string MessageId { get; set; } = string.Empty;
    public string ServiceId { get; set; } = string.Empty;
    public string ShortCode { get; set; } = string.Empty;
    public string Keyword { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string Sender { get; set; } = string.Empty;
    public string Operator { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
}