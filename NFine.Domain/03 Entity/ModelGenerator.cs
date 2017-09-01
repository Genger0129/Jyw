// This file was automatically generated by the Dapper.SimpleCRUD T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DefaultConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.;Initial Catalog=NFineBase;persist security info=True;user id=sa;Password=******;`
//     Include Views:          `True`

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using NFine.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Domain.Entity
{
    /// <summary>
    /// A class which represents the Province table.
    /// </summary>
	public partial class ProvinceEntity: IEntity<ProvinceEntity>
	{
		[Key]
		[RequiredAttribute]
		public virtual Guid ProvinceId { get; set; }
		public virtual string ProvinceName { get; set; }
		public virtual int? State { get; set; }
	}

}

