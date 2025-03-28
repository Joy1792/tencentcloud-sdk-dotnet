/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainPriceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询价格的后缀列表。默认则为全部后缀
        /// </summary>
        [JsonProperty("TldList")]
        public string[] TldList{ get; set; }

        /// <summary>
        /// 查询购买的年份，默认会列出所有年份的价格
        /// </summary>
        [JsonProperty("Year")]
        public long?[] Year{ get; set; }

        /// <summary>
        /// 域名的购买类型：new  新购，renew 续费，redem 赎回，tran 转入
        /// </summary>
        [JsonProperty("Operation")]
        public string[] Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TldList.", this.TldList);
            this.SetParamArraySimple(map, prefix + "Year.", this.Year);
            this.SetParamArraySimple(map, prefix + "Operation.", this.Operation);
        }
    }
}

