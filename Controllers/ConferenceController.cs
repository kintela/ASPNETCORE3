using System;
using globomantics.Services;
using Microsoft.AspNetCore.Mvc;

namespace globomantics.Controllers
{
  public class ConferenceController:Controller
  {
    public ConferenceController(IConferenceServices conferenceService)
    {
    }
  }
}
