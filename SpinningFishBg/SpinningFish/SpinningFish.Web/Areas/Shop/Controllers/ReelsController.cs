﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpinningFish.Services.Shop;

namespace SpinningFish.Web.Areas.Shop.Controllers
{

    public class ReelsController : BaseShopController
    {
        private readonly IReelService reels;
        private readonly IBrandService brands;

        public ReelsController(
            IReelService reels, 
            IBrandService brands)
        {
            this.reels = reels;
            this.brands = brands;
        }

        public async Task<IActionResult> All(int id)
        {
            var allReels = await this.reels.AllReelsByIdBrandAsync(id);
            
            return this.View(allReels);
        }

        public async Task<IActionResult> Details(int id)
        {
            var allReels = await this.reels.DetailsReelByIdAsync(id);

            return this.View(allReels);
        }
    }
}
