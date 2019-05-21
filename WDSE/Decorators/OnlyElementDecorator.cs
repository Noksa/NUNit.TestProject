﻿using System;
using System.Drawing;
using ImageMagick;
using OpenQA.Selenium;
using WDSE.Helpers;
using WDSE.Interfaces;

namespace WDSE.Decorators
{
    public class OnlyElementDecorator : BaseScreenshotDecorator
    {
        #region Private fields

        private By _by;

        #endregion

        #region Ctor

        public OnlyElementDecorator(IScreenshotStrategy strategy) : base(strategy)
        {
        }

        #endregion

        #region Override

        public override IMagickImage MakeScreenshot(IWebDriver driver)
        {
            return TakeOnlyElementScreenshot(driver, NestedStrategy.MakeScreenshot(driver));
        }

        #endregion


        #region Public Methods

        /// <summary>
        ///     Sets the element whose screenshot is to be made.
        /// </summary>
        /// <param name="by">How to find element.</param>
        /// <returns></returns>
        public OnlyElementDecorator SetElement(By by)
        {
            _by = by;
            return this;
        }

        #endregion

        #region Privates

        private IMagickImage TakeOnlyElementScreenshot(IWebDriver driver, IMagickImage magickImage)
        {
            if (_by == null)
                throw new ArgumentNullException(
                    $"Element is not setted. Before using {nameof(OnlyElementDecorator)}, call the method {nameof(SetElement)}.");
            var coords = driver.GetElementCoordinates(_by);

            if (!driver.IsElementInViewPort(coords.y, coords.bottom))
            {
                driver.ScrollToElement(_by);
                coords = driver.GetElementCoordinates(_by);
                magickImage = NestedStrategy.MakeScreenshot(driver);
            }

            var rectangle = new Rectangle(coords.x, coords.y, coords.width, coords.height);
            var image = magickImage.Clone(rectangle.ToMagickGeometry());
            return image;
        }

        #endregion
    }
}