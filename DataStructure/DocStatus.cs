using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 文档状态
    /// </summary>
    public enum DocStatus
    {
        unmake,         //未制作
        saved,          //已保存
        submitted,      //已提交
        returned,       //已退回
        modified,       //已修改
        passed          //通过
    }
}