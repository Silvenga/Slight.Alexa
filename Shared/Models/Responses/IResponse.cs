using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Slight.Alexa.Framework.Models.Responses
{
    public interface IResponse
    {
        [Required]
        string Type { get; }
    }
}
