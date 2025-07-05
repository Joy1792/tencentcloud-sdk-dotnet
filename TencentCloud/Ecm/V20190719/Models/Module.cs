/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Module : AbstractModel
    {
        
        /// <summary>
        /// 模块Id。
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 模块名称。
        /// </summary>
        [JsonProperty("ModuleName")]
        public string ModuleName{ get; set; }

        /// <summary>
        /// 模块状态：
        /// NORMAL：正常。
        /// DELETING：删除中 
        /// DELETEFAILED：删除失败。
        /// </summary>
        [JsonProperty("ModuleState")]
        public string ModuleState{ get; set; }

        /// <summary>
        /// 默认系统盘大小。
        /// </summary>
        [JsonProperty("DefaultSystemDiskSize")]
        public long? DefaultSystemDiskSize{ get; set; }

        /// <summary>
        /// 默认数据盘大小。
        /// </summary>
        [JsonProperty("DefaultDataDiskSize")]
        public long? DefaultDataDiskSize{ get; set; }

        /// <summary>
        /// 默认机型。
        /// </summary>
        [JsonProperty("InstanceTypeConfig")]
        public InstanceTypeConfig InstanceTypeConfig{ get; set; }

        /// <summary>
        /// 默认镜像。
        /// </summary>
        [JsonProperty("DefaultImage")]
        public Image DefaultImage{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 默认出带宽。
        /// </summary>
        [JsonProperty("DefaultBandwidth")]
        public long? DefaultBandwidth{ get; set; }

        /// <summary>
        /// 标签集合。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 是否关闭IP直通。
        /// </summary>
        [JsonProperty("CloseIpDirect")]
        public long? CloseIpDirect{ get; set; }

        /// <summary>
        /// 默认安全组id列表。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 默认入带宽。
        /// </summary>
        [JsonProperty("DefaultBandwidthIn")]
        public long? DefaultBandwidthIn{ get; set; }

        /// <summary>
        /// 自定义脚本数据
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 系统盘信息。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 数据盘信息。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 是否禁止外网ip
        /// </summary>
        [JsonProperty("DisableWanIp")]
        public long? DisableWanIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "ModuleName", this.ModuleName);
            this.SetParamSimple(map, prefix + "ModuleState", this.ModuleState);
            this.SetParamSimple(map, prefix + "DefaultSystemDiskSize", this.DefaultSystemDiskSize);
            this.SetParamSimple(map, prefix + "DefaultDataDiskSize", this.DefaultDataDiskSize);
            this.SetParamObj(map, prefix + "InstanceTypeConfig.", this.InstanceTypeConfig);
            this.SetParamObj(map, prefix + "DefaultImage.", this.DefaultImage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DefaultBandwidth", this.DefaultBandwidth);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "CloseIpDirect", this.CloseIpDirect);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "DefaultBandwidthIn", this.DefaultBandwidthIn);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "DisableWanIp", this.DisableWanIp);
        }
    }
}

