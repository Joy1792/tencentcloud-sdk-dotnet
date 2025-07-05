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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceBillingData : AbstractModel
    {
        
        /// <summary>
        /// 资源名称，根据查询条件不同分为以下几类：
        /// 某一个具体域名：表示该域名明细数据
        /// multiDomains：表示多域名汇总明细数据
        /// 某一个项目 ID：指定项目查询时，显示为项目 ID
        /// all：账号维度数据明细
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 计费数据详情
        /// </summary>
        [JsonProperty("BillingData")]
        public CdnData[] BillingData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamArrayObj(map, prefix + "BillingData.", this.BillingData);
        }
    }
}

