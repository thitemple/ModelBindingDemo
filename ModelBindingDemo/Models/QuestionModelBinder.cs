using System;
using System.Web.Mvc;
using Castle.MicroKernel;

namespace MvcApplicationCustomModelBinder.Models
{
    public class QuestionModelBinder : DefaultModelBinder
    {
        private readonly IKernel _kernel;

        public QuestionModelBinder(IKernel kernel)
        {
            _kernel = kernel;
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = base.BindModel(controllerContext, bindingContext) as Question;
            var categoryId = Convert.ToInt32(bindingContext.ValueProvider.GetValue("CategoryId").AttemptedValue);
            var db = _kernel.Resolve<QuestionsContext>();
            model.Category = db.Categories.Find(categoryId);
            return model;
        }
    }
}