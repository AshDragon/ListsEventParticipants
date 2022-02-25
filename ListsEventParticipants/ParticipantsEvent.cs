using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListsEventParticipants
{
    [Serializable]
   public class ParticipantsEvent
    {
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("RegistrationDate")]
        public DateTimeOffset RegistrationDate { get; set; }
      
    }
    //Времменный класс (ParticipantsEvent) я пока разбираюсь с json и возможно будет рефакторинг кода.
    //если получиться выполнить заданную задачу то отрефакторю код для удобства дальнейшего использования, а пока разбираюсь код оставлю такой как есть 
}
