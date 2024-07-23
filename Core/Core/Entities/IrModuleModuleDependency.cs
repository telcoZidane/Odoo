using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrModuleModuleDependency
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ModuleId { get; set; }

    public bool? AutoInstallRequired { get; set; }

    public virtual IrModuleModule? Module { get; set; }
}
