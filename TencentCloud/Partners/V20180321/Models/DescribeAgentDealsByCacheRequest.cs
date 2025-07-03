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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentDealsByCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目 最大200
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 下单时间范围起始点【*请必传并控制时间范围最大90天，避免出现超时】
        /// </summary>
        [JsonProperty("CreatTimeRangeStart")]
        public string CreatTimeRangeStart{ get; set; }

        /// <summary>
        /// 下单时间范围终止点【*请必传并控制时间范围最大90天，避免出现超时】
        /// </summary>
        [JsonProperty("CreatTimeRangeEnd")]
        public string CreatTimeRangeEnd{ get; set; }

        /// <summary>
        /// 0:下单时间降序；其他：下单时间升序
        /// </summary>
        [JsonProperty("Order")]
        public ulong? Order{ get; set; }

        /// <summary>
        /// 子订单状态(1-待支付,2-已支付,3-发货中,4-已发货,5-发货失败,6-已退款,7-已取消,8-已过期,9-已失效,12-支付中,13-退款中,30-处理中)
        /// 
        /// 控制台订单状态为以上状态的组合：未支付(1) 处理中(2,3,5,12,13,30) 已取消(7) 交易成功(4) 已过期(8) 已退款(6) 订单错误(9)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 下单人账号ID列表
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string[] OwnerUins{ get; set; }

        /// <summary>
        /// 子订单号列表
        /// </summary>
        [JsonProperty("DealNames")]
        public string[] DealNames{ get; set; }

        /// <summary>
        /// 大订单号列表
        /// </summary>
        [JsonProperty("BigDealIds")]
        public string[] BigDealIds{ get; set; }

        /// <summary>
        /// 支付方式，0：自付；1：代付
        /// </summary>
        [JsonProperty("PayerMode")]
        public ulong? PayerMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreatTimeRangeStart", this.CreatTimeRangeStart);
            this.SetParamSimple(map, prefix + "CreatTimeRangeEnd", this.CreatTimeRangeEnd);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "OwnerUins.", this.OwnerUins);
            this.SetParamArraySimple(map, prefix + "DealNames.", this.DealNames);
            this.SetParamArraySimple(map, prefix + "BigDealIds.", this.BigDealIds);
            this.SetParamSimple(map, prefix + "PayerMode", this.PayerMode);
        }
    }
}

