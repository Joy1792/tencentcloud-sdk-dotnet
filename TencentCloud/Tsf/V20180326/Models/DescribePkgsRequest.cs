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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePkgsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID（只传入应用ID，返回该应用下所有软件包信息）
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 查询关键字（支持根据包ID，包名，包版本号搜索）
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 排序关键字（默认为"UploadTime"：上传时间）
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 升序：0/降序：1（默认降序）
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// 查询起始偏移
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量限制
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 程序包仓库类型
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// 程序包仓库id
        /// </summary>
        [JsonProperty("RepositoryId")]
        public string RepositoryId{ get; set; }

        /// <summary>
        /// 程序包类型数组支持（fatjar jar war tar.gz zip）
        /// </summary>
        [JsonProperty("PackageTypeList")]
        public string[] PackageTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "RepositoryId", this.RepositoryId);
            this.SetParamArraySimple(map, prefix + "PackageTypeList.", this.PackageTypeList);
        }
    }
}

