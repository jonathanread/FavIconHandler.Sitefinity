using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace FavIconHandler.Sitefinity
{
	/// <summary>
	/// Localizable strings for the FavIconHandler module
	/// </summary>
	/// <remarks>
	/// You can use Sitefinity Thunder to edit this file.
	/// To do this, open the file's context menu and select Edit with Thunder.
	/// 
	/// If you wish to install this as a part of a custom module,
	/// add this to the module's Initialize method:
	/// App.WorkWith()
	///     .Module(ModuleName)
	///     .Initialize()
	///         .Localization<FavIconHandlerResources>();
	/// </remarks>
	/// <see cref="http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-import-events-from-facebook/creating-the-resources-class"/>
	[ObjectInfo("FavIconHandlerResources", ResourceClassId = "FavIconHandlerResources", Title = "FavIconHandlerResourcesTitle", TitlePlural = "FavIconHandlerResourcesTitlePlural", Description = "FavIconHandlerResourcesDescription")]
	public class FavIconHandlerResources : Resource
	{
		#region Construction
		/// <summary>
		/// Initializes new instance of <see cref="FavIconHandlerResources"/> class with the default <see cref="ResourceDataProvider"/>.
		/// </summary>
		public FavIconHandlerResources()
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="FavIconHandlerResources"/> class with the provided <see cref="ResourceDataProvider"/>.
		/// </summary>
		/// <param name="dataProvider"><see cref="ResourceDataProvider"/></param>
		public FavIconHandlerResources(ResourceDataProvider dataProvider)
			: base(dataProvider)
		{
		}
		#endregion

		#region Class Description
		/// <summary>
		/// FavIconHandler Resources
		/// </summary>
		[ResourceEntry("FavIconHandlerResourcesTitle",
			Value = "FavIconHandler module labels",
			Description = "The title of this class.",
			LastModified = "2015/04/29")]
		public string FavIconHandlerResourcesTitle
		{
			get
			{
				return this["FavIconHandlerResourcesTitle"];
			}
		}

		/// <summary>
		/// FavIconHandler Resources Title plural
		/// </summary>
		[ResourceEntry("FavIconHandlerResourcesTitlePlural",
			Value = "FavIconHandler module labels",
			Description = "The title plural of this class.",
			LastModified = "2015/04/29")]
		public string FavIconHandlerResourcesTitlePlural
		{
			get
			{
				return this["FavIconHandlerResourcesTitlePlural"];
			}
		}

		/// <summary>
		/// Contains localizable resources for FavIconHandler module.
		/// </summary>
		[ResourceEntry("FavIconHandlerResourcesDescription",
			Value = "Contains localizable resources for FavIconHandler module.",
			Description = "The description of this class.",
			LastModified = "2015/04/29")]
		public string FavIconHandlerResourcesDescription
		{
			get
			{
				return this["FavIconHandlerResourcesDescription"];
			}
		}
		#endregion
	}
}