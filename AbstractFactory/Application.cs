﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Application
    {
        private IUIElementFactory _elementFactory;

        public Application(IUIElementFactory elementFactor)
        {
            _elementFactory = elementFactor;
        }

        public void RenderUI()
        {
            var createNewFileButton = _elementFactory.CreateButton();

            createNewFileButton.Render();

            var textbox = _elementFactory.CreateTextbox();

            textbox.Render();
        }
    }
}
