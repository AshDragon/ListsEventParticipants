using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


namespace ListsEventParticipants
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<ParticipantsEvent> participantsEvents = new List<ParticipantsEvent>();

            var path = "participants.json";
            string jsonString;
            ParticipantsEvent participantsEvent = new ParticipantsEvent();

            jsonString = File.ReadAllText(path);
            Console.WriteLine(jsonString);
           

            Console.ReadLine();
        }
        //как я понял данный кусок кода десериализирует данные из файла json и выводит данные в консоль, но остаёться вопрос на сколько это безопасно написанный код

        //это временная реализация кода для решения задачи
        //я не знаю какой тут должен быть код и поэтому буду разбираться методом эксперементально-иследовательского написания кода и после того как более менее разбирусь займусь рефакторингом кода
        //и уберу излишнии коментарии и оставлю лиш коментарии к пониманию написанного кода
    }
}








//пробую разные реализации и в конце все  ненужные коменты почищю
/*JsonTextReader reader = new JsonTextReader(new StreamReader("participants.json"));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
            }
            JsonSerializer serializer = new JsonSerializer();
            ParticipantEvent temp_Event = serializer.Deserialize<ParticipantEvent>(reader);
            participantEvents.Add(temp_Event);

            for (int i = 0; i < participantEvents.Count; i++)
                Console.WriteLine(participantEvents[i].FirstName + " " +
                    participantEvents[i].LastName + " " + participantEvents[i].RegistrationDate);
           */
/*Console.WriteLine(participantEvents[i].FirstName + " " +
       participantEvents[i].LastName + " " + participantEvents[i].RegistrationDate);*/
/* 
 * //  ParticipantEvent participantEvent = new ParticipantEvent();
 * //string fileName = "participants.json";
 var path = "participants.json";
 string jsonString;
 ParticipantEvent participantEvent = new ParticipantEvent();

 jsonString = File.ReadAllText(path); 

 Console.WriteLine(jsonString);   
 //   ParticipantEvent participantEvent = JsonSerializer.Deserialize<ParticipantEvent>(jsonString)!;
 var participantEvents = JsonConvert.DeserializeObject<List<ParticipantEvent>>(jsonString);
 participantEvent = participantEvents.First();


 Console.WriteLine($"RegistrationDate: {participantEvent.RegistrationDate}");
 Console.WriteLine($"FirstName: {participantEvent.FirstName}");
 Console.WriteLine($"LastName: {participantEvent.LastName}");
 */
