using System.Web.Mvc;

namespace MvcApplicationCustomModelBinder.Models
{
    public class CustomModelBinder<T> : DefaultModelBinder where T : Entity
    {
        private readonly QuestionsContext _db;

        public CustomModelBinder(QuestionsContext db)
        {    
            _db = db;
        }

        public override object BindModel(ControllerContext controllerContext, 
            ModelBindingContext bindingContext)
        {
            var model = base.BindModel(controllerContext, bindingContext) as T;

            foreach (var property in typeof(T).GetProperties())
            {
                if (property.PropertyType.BaseType == typeof(Entity))
                {
                    var result = bindingContext.ValueProvider.GetValue(string.Format("{0}Id",
                        property.Name));
                    if(result != null)
                    {
                        var rawIdValue = result.AttemptedValue;
                        int id;
                        if (int.TryParse(rawIdValue, out id))
                        {
                            if (id != 0)
                            {
                                var value = _db.Set(property.PropertyType).Find(id);
                                property.SetValue(model, value, null);
                            }
                        }
                    }
                }
            }
            return model;
        }
    }
}