using Newtonsoft.Json;

namespace MyTicket.DTO.TicketMasterResponses;

public class Source
{
    [JsonProperty("mfx-nl")]
    public int mfxnl { get; set; }
    public int? ticketmaster { get; set; }
    public int? tmr { get; set; }
    public int? ticketnet { get; set; }

    [JsonProperty("mfx-be")]
    public int? mfxbe { get; set; }

    [JsonProperty("mfx-de")]
    public int? mfxde { get; set; }

    [JsonProperty("mfx-pl")]
    public int? mfxpl { get; set; }

    [JsonProperty("mfx-cz")]
    public int? mfxcz { get; set; }

    [JsonProperty("mfx-dk")]
    public int? mfxdk { get; set; }

    [JsonProperty("mfx-se")]
    public int? mfxse { get; set; }

    [JsonProperty("mfx-es")]
    public int? mfxes { get; set; }

    [JsonProperty("mfx-it")]
    public int? mfxit { get; set; }

    [JsonProperty("mfx-no")]
    public int? mfxno { get; set; }

    [JsonProperty("mfx-fi")]
    public int? mfxfi { get; set; }
    public int? moshtix { get; set; }
    public int? ticketweb { get; set; }

    [JsonProperty("mfx-at")]
    public int? mfxat { get; set; }
}