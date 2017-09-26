using EOrg.Core.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EOrg.Core;
using EOrg.Web.App_Start;
using Microsoft.AspNet.Identity;
using Ninject.Modules;
using Proggasoft.Diagnosis;
using Proggasoft.Mvc;

namespace EOrg.Web.Models
{
    public class ProductModel : IProductModel
    {
        private readonly ICoreUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogHelperFactory _logHelperFactory;
        private readonly IServerTime _serverTime;
        public ProductModel()
        {
            _unitOfWorkFactory = NinjectWebCommon.GetConcreteInstance<ICoreUnitOfWorkFactory>();
            _logHelperFactory = NinjectWebCommon.GetConcreteInstance<ILogHelperFactory>();
            _serverTime = NinjectWebCommon.GetConcreteInstance<IServerTime>();
        }

        public bool AddProduct(ProductViewModel model)
        {
            try
            {
                var product = new Product()
                {
                    Price = model.SellPrice,
                    Name = model.Name,
                    Model = model.Model,
                    SubCategoryId = model.SubCategoryId,
                    EmiAvailable = model.TotalInstallment != null,
                    Specification = new Specification()
                    {
                        Weight = model.Weight,
                        DisplaySize = model.DisplaySize,
                        FrontCamera = model.FrontCamera,
                        BackCamera = model.BackCamera,
                        CpuSpeed = model.CpuSpeed,
                        Ram = model.Ram,
                        Rom = model.Rom,
                        Battery = model.Battery,
                        SimCard = model.SimCard,
                        Processor = model.Processor,
                        Warranty = model.Warranty,
                        BrandId = model.BrandId
                    },
                    CreatedOn = _serverTime.CurrentDateTime,
                    CreatedBy = HttpContext.Current.User.Identity.GetUserId(),
                    UpdatedOn = _serverTime.CurrentDateTime,
                    UpdatedBy = HttpContext.Current.User.Identity.GetUserId()
                };

                var quantity = new List<ProductQuantity>();
                for (int i = 0; i < model.ItemQuantity.Length; i++)
                {
                    quantity.Add(new ProductQuantity()
                    {
                        Quantity = model.ItemQuantity[i],
                        ColorId = model.ColorId[i]
                    });
                }
                product.Quantity = quantity;

                var emi = new List<EmiType>();
                if (model.TotalInstallment != null)
                {
                    for (int i = 0; i < model.TotalInstallment.Length; i++)
                    {
                        emi.Add(new EmiType()
                        {
                            TotalInstallment = model.TotalInstallment[i],
                            PayAmount = model.PayAmount[i]
                        });
                    }
                }
                product.Emi = emi;

                using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
                {
                    unitOfWork.ProductRepository.Insert(product);
                    unitOfWork.Save();
                }
                return true;
            }
            catch (Exception e)
            {
                _logHelperFactory.Create().WriteLog(LogType.HandledLog, this.GetType().ToString(), "AddProduct", e,
                    "Failed to save new product");
                NotyMessage.CreateNotyMessage("Failed to save new product", NotyMessageType.error);
                return false;
            }
        }
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public Guid SubCategoryId { get; set; }
        public double? Weight { get; set; }
        public double? DisplaySize { get; set; }
        public double? FrontCamera { get; set; }
        public double? BackCamera { get; set; }
        public double? CpuSpeed { get; set; }
        public double? Ram { get; set; }
        public double? Rom { get; set; }
        public string Battery { get; set; }
        public string SimCard { get; set; }
        public string Processor { get; set; }
        public string Warranty { get; set; }
        public Guid BrandId { get; set; }
        public int[] ItemQuantity { get; set; }
        public Guid?[] ColorId { get; set; }
        public int[] PayAmount { get; set; }
        public int[] TotalInstallment { get; set; }
        public bool EmiAvailable { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Specification Specification { get; set; }
        public virtual List<CustomField> OtherField { get; set; }
        public virtual List<ProductQuantity> Quantity { get; set; }
        public virtual List<EmiType> EmiType { get; set; }
    }
}