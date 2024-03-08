using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class InventoryMediator : IMediator
    {
        public Crafting Crafting { get; set; }
        public EntityPlacer EntityPlacer { get; set; }
        public WorkSystem WorkSystem { get; set; }
        public RecipeSystem RecipeSystem { get; set; }
        public Inventory Inventory { get; set; }

        public void Send(IBaseComponent component, string message)
        {
            var sender = component.Name.ToLower();

            switch (sender)
            {
                case "crafting":
                    Inventory.Notify(sender, message);
                    WorkSystem.Notify(sender, message);
                    break;
                case "entityPlacer":
                    Inventory.Notify(sender, message);
                    break;
                case "recipesystem":
                    Inventory.Notify(sender, message);
                    Crafting.Notify(sender, message);
                    break;
                default:
                    break;
            }
        }
    }
}
