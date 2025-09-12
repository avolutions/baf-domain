using Avolutions.Baf.Domain.Communications.Models;

namespace Avolutions.Baf.Domain.Communications.Abstractions;

public interface IHasCommunication
{
    public Guid CommunicationId  { get; set; }
    public Communication Communication { get; set; }
}