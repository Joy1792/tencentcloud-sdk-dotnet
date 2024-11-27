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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationAverageData : AbstractModel
    {
        
        /// <summary>
        /// 起始月份
        /// </summary>
        [JsonProperty("BeginMonth")]
        public string BeginMonth{ get; set; }

        /// <summary>
        /// 结束月份
        /// </summary>
        [JsonProperty("EndMonth")]
        public string EndMonth{ get; set; }

        /// <summary>
        /// 合计费用(折后总额)平均值
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginMonth", this.BeginMonth);
            this.SetParamSimple(map, prefix + "EndMonth", this.EndMonth);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
        }
    }
}

