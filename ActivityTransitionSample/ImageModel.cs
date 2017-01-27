using System;
using System.Collections.Generic;

namespace ActivityTransitionSample
{
	public class ImageModel
	{
		public string RightImageUrl { get; set; }
		public string LeftImageUrl { get; set; }

		public static IList<ImageModel> GenerateList()
		{
			return new List<ImageModel>
			{
				new ImageModel
				{
					RightImageUrl ="http://www.v3wall.com/wallpaper/1920_1080/1005/1920_1080_201005041212101446317.jpg",
					LeftImageUrl = "http://gazou.kizitora.jp/wp-content/uploads/2014/10/167_wallpaper_1920x1080_fullhd.jpg"
				},
				new ImageModel
				{
					RightImageUrl ="http://www.wallpaperstop.com/wallpapers/nature-wallpapers/scenery-wallpapers/green-scenery-wallpaper-1920x1080-1010113.jpg",
					LeftImageUrl = "http://k-kabegami.com/garyuyozakura/1920.jpg"
				},
				new ImageModel
				{
					RightImageUrl ="http://kobe.travel.coocan.jp/WUXGA-FULLHD/kobeyakei/0004-1920x1080.jpg",
					LeftImageUrl = "http://blog-imgs-93.fc2.com/k/a/m/kamikeiba/20160613090425855.jpg"
				},
				new ImageModel
				{
					RightImageUrl="http://door2.me/wp-content/uploads/2016/12/0006-1920x1080.jpg",
					LeftImageUrl = "http://www.wallpaperstop.com/wallpapers/nature-wallpapers/summer-wallpapers/summer-beach-background-1920x1080-1109051.jpg"
				},
				new ImageModel
				{
					RightImageUrl="http://www.wallpaper-box.com/forest/19201080/images/forest88.jpg",
					LeftImageUrl = "http://www.wallpaper77.com/upload/DesktopWallpapers/cache/Hilltop-Mountain-Skys-HDR-abstract-wallpapers-world-abstract-1920x1080.jpg"
				},
				new ImageModel
				{
					RightImageUrl="http://www.v3wall.com/wallpaper/1920_1080/0911/1920_1080_20091110090613500035.jpg",
					LeftImageUrl = "http://www.wallpaperstop.com/wallpapers/nature-wallpapers/spring-wallpapers/grass-wallpaper-1920x1080-1110104.jpg"
				},
			};
		}
	}
}
