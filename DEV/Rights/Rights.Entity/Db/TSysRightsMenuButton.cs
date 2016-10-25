using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Rights.Entity.Attributes;

/// <summary>
/// 
/// </summary>
namespace Rights.Entity.Db
{
	[Serializable]
	[DataContract(IsReference = true)]
	[Table("dbo.t_sys_rights_menu_button")]
	public partial class TSysRightsMenuButton
	{
		public TSysRightsMenuButton()
		{
			
		}

		/// <summary>
		/// id
		/// </summary>
		[DataMember]
		[Column("id", ColumnCategory=Category.IdentityKey)]
		public int Id { get; set; }
		
		/// <summary>
		/// 菜单id
		/// </summary>
		[DataMember]
		[Column("menu_id")] 
		public int? MenuId { get; set; }
		
		/// <summary>
		/// 按钮id
		/// </summary>
		[DataMember]
		[Column("button_id")] 
		public int? ButtonId { get; set; }
		
	}
}