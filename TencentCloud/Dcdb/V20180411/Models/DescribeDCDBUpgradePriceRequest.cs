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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDCDBUpgradePriceRequest : AbstractModel
    {
        
        /// <summary>
        /// 待升级的实例ID。形如：dcdbt-ow728lmc，可以通过 DescribeDCDBInstances 查询实例详情获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 升级类型，取值范围: 
        /// <li> ADD: 新增分片 </li> 
        ///  <li> EXPAND: 升级实例中的已有分片 </li> 
        ///  <li> SPLIT: 将已有分片中的数据切分到新增分片上</li>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// 新增分片配置，当UpgradeType为ADD时生效。
        /// </summary>
        [JsonProperty("AddShardConfig")]
        public AddShardConfig AddShardConfig{ get; set; }

        /// <summary>
        /// 扩容分片配置，当UpgradeType为EXPAND时生效。
        /// </summary>
        [JsonProperty("ExpandShardConfig")]
        public ExpandShardConfig ExpandShardConfig{ get; set; }

        /// <summary>
        /// 切分分片配置，当UpgradeType为SPLIT时生效。
        /// </summary>
        [JsonProperty("SplitShardConfig")]
        public SplitShardConfig SplitShardConfig{ get; set; }

        /// <summary>
        /// 价格金额单位，不传默认单位为分，取值：  
        /// * pent：分
        /// * microPent：微分
        /// </summary>
        [JsonProperty("AmountUnit")]
        public string AmountUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamObj(map, prefix + "AddShardConfig.", this.AddShardConfig);
            this.SetParamObj(map, prefix + "ExpandShardConfig.", this.ExpandShardConfig);
            this.SetParamObj(map, prefix + "SplitShardConfig.", this.SplitShardConfig);
            this.SetParamSimple(map, prefix + "AmountUnit", this.AmountUnit);
        }
    }
}

