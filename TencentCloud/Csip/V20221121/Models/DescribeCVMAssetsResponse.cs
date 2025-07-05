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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCVMAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 机器列表
        /// </summary>
        [JsonProperty("Data")]
        public CVMAssetVO[] Data{ get; set; }

        /// <summary>
        /// 地域列表
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// 防护状态
        /// </summary>
        [JsonProperty("DefenseStatusList")]
        public FilterDataObject[] DefenseStatusList{ get; set; }

        /// <summary>
        /// vpc枚举
        /// </summary>
        [JsonProperty("VpcList")]
        public FilterDataObject[] VpcList{ get; set; }

        /// <summary>
        /// 资产类型枚举
        /// </summary>
        [JsonProperty("AssetTypeList")]
        public FilterDataObject[] AssetTypeList{ get; set; }

        /// <summary>
        /// 操作系统枚举
        /// </summary>
        [JsonProperty("SystemTypeList")]
        public FilterDataObject[] SystemTypeList{ get; set; }

        /// <summary>
        /// ip列表
        /// </summary>
        [JsonProperty("IpTypeList")]
        public FilterDataObject[] IpTypeList{ get; set; }

        /// <summary>
        /// appid列表
        /// </summary>
        [JsonProperty("AppIdList")]
        public FilterDataObject[] AppIdList{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("ZoneList")]
        public FilterDataObject[] ZoneList{ get; set; }

        /// <summary>
        /// os列表
        /// </summary>
        [JsonProperty("OsList")]
        public FilterDataObject[] OsList{ get; set; }

        /// <summary>
        /// 资产类型和实例类型的对应关系
        /// </summary>
        [JsonProperty("AssetMapInstanceTypeList")]
        public AssetInstanceTypeMap[] AssetMapInstanceTypeList{ get; set; }

        /// <summary>
        /// 公网内网枚举
        /// </summary>
        [JsonProperty("PublicPrivateAttr")]
        public FilterDataObject[] PublicPrivateAttr{ get; set; }

        /// <summary>
        /// 主机防护状态
        /// </summary>
        [JsonProperty("ProtectStatusList")]
        public FilterDataObject[] ProtectStatusList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArrayObj(map, prefix + "DefenseStatusList.", this.DefenseStatusList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArrayObj(map, prefix + "AssetTypeList.", this.AssetTypeList);
            this.SetParamArrayObj(map, prefix + "SystemTypeList.", this.SystemTypeList);
            this.SetParamArrayObj(map, prefix + "IpTypeList.", this.IpTypeList);
            this.SetParamArrayObj(map, prefix + "AppIdList.", this.AppIdList);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamArrayObj(map, prefix + "OsList.", this.OsList);
            this.SetParamArrayObj(map, prefix + "AssetMapInstanceTypeList.", this.AssetMapInstanceTypeList);
            this.SetParamArrayObj(map, prefix + "PublicPrivateAttr.", this.PublicPrivateAttr);
            this.SetParamArrayObj(map, prefix + "ProtectStatusList.", this.ProtectStatusList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

