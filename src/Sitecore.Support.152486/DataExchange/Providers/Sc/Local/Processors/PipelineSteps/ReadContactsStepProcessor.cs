using Sitecore.Analytics.Tracking;
using Sitecore.localhost;

namespace Sitecore.Support.DataExchange.Providers.Sc.Local.Processors.PipelineSteps
{
  public class ReadContactsStepProcessor:Sitecore.DataExchange.Providers.Sc.Local.Processors.PipelineSteps.ReadContactsStepProcessor
  {
    protected override bool ShouldHandleContact(Contact contact)
    {
      return (base.ShouldHandleContact(contact) && !string.IsNullOrEmpty(contact.Identifiers.Identifier));
    }
  }
}