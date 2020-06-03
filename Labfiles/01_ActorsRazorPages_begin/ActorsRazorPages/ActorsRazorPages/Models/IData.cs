using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsRazorPages.Models
{
    public interface IData
    {
        public List<Actor> ActorsList { get; set; }

        public List<Actor> ActorsInitializeData();
        public Actor GetActorById(int? id);

    }
}
