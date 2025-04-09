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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupApiUseStatistics : AbstractModel
    {
        
        /// <summary>
        /// 总调用数
        /// </summary>
        [JsonProperty("TopStatusCode")]
        public ApiUseStatisticsEntity[] TopStatusCode{ get; set; }

        /// <summary>
        /// 平均错误率
        /// </summary>
        [JsonProperty("TopTimeCost")]
        public ApiUseStatisticsEntity[] TopTimeCost{ get; set; }

        /// <summary>
        /// 分位值对象
        /// </summary>
        [JsonProperty("Quantile")]
        public QuantileEntity Quantile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TopStatusCode.", this.TopStatusCode);
            this.SetParamArrayObj(map, prefix + "TopTimeCost.", this.TopTimeCost);
            this.SetParamObj(map, prefix + "Quantile.", this.Quantile);
        }
    }
}

