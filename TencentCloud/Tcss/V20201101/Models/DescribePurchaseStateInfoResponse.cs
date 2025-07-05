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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePurchaseStateInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 0：可申请试用可购买；1：只可购买(含试用审核不通过和试用过期)；2：试用生效中；3：专业版生效中；4：专业版过期
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 总资源核数 = 总防护核数 + 未防护核数
        /// </summary>
        [JsonProperty("AllCoresCnt")]
        public ulong? AllCoresCnt{ get; set; }

        /// <summary>
        /// 总防护核数 =已购核数+ 试用赠送核数 +弹性计费核数
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// 未防护核数(未开启防护资源核数)
        /// </summary>
        [JsonProperty("UndefendCoresCnt")]
        public ulong? UndefendCoresCnt{ get; set; }

        /// <summary>
        /// 已购买核数
        /// </summary>
        [JsonProperty("AuthorizedCoresCnt")]
        public ulong? AuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// 试用赠送专业版核心数
        /// </summary>
        [JsonProperty("GivenAuthorizedCoresCnt")]
        public long? GivenAuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// 当前弹性计费核数数量
        /// </summary>
        [JsonProperty("CurrentFlexibleCoresCnt")]
        public ulong? CurrentFlexibleCoresCnt{ get; set; }

        /// <summary>
        /// 镜像数
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// 已授权镜像数
        /// </summary>
        [JsonProperty("AuthorizedImageCnt")]
        public ulong? AuthorizedImageCnt{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// 已购买镜像授权数
        /// </summary>
        [JsonProperty("PurchasedAuthorizedCnt")]
        public ulong? PurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// 0表示默认状态(用户未设置，即初始状态)， 1表示自动续费，2表示明确不自动续费(用户设置)
        /// </summary>
        [JsonProperty("AutomaticRenewal")]
        public long? AutomaticRenewal{ get; set; }

        /// <summary>
        /// 试用期间赠送镜像授权数，可能会过期
        /// </summary>
        [JsonProperty("GivenAuthorizedCnt")]
        public ulong? GivenAuthorizedCnt{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 子状态(具体意义依据State字段而定)
        /// State为4时，有效值为: ISOLATE(隔离) DESTROED(已销毁)
        /// </summary>
        [JsonProperty("SubState")]
        public string SubState{ get; set; }

        /// <summary>
        /// 计费key
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// 防护策略
        /// </summary>
        [JsonProperty("DefendPolicy")]
        public string DefendPolicy{ get; set; }

        /// <summary>
        /// 弹性计费核数上限
        /// </summary>
        [JsonProperty("FlexibleCoresLimit")]
        public ulong? FlexibleCoresLimit{ get; set; }

        /// <summary>
        /// 已防护集群核数
        /// </summary>
        [JsonProperty("DefendClusterCoresCnt")]
        public ulong? DefendClusterCoresCnt{ get; set; }

        /// <summary>
        /// 已防护主机核数
        /// </summary>
        [JsonProperty("DefendHostCoresCnt")]
        public ulong? DefendHostCoresCnt{ get; set; }

        /// <summary>
        /// 试用的专业版核数
        /// </summary>
        [JsonProperty("TrialCoresCnt")]
        public ulong? TrialCoresCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AllCoresCnt", this.AllCoresCnt);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "UndefendCoresCnt", this.UndefendCoresCnt);
            this.SetParamSimple(map, prefix + "AuthorizedCoresCnt", this.AuthorizedCoresCnt);
            this.SetParamSimple(map, prefix + "GivenAuthorizedCoresCnt", this.GivenAuthorizedCoresCnt);
            this.SetParamSimple(map, prefix + "CurrentFlexibleCoresCnt", this.CurrentFlexibleCoresCnt);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "AuthorizedImageCnt", this.AuthorizedImageCnt);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
            this.SetParamSimple(map, prefix + "PurchasedAuthorizedCnt", this.PurchasedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "AutomaticRenewal", this.AutomaticRenewal);
            this.SetParamSimple(map, prefix + "GivenAuthorizedCnt", this.GivenAuthorizedCnt);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "SubState", this.SubState);
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamSimple(map, prefix + "DefendPolicy", this.DefendPolicy);
            this.SetParamSimple(map, prefix + "FlexibleCoresLimit", this.FlexibleCoresLimit);
            this.SetParamSimple(map, prefix + "DefendClusterCoresCnt", this.DefendClusterCoresCnt);
            this.SetParamSimple(map, prefix + "DefendHostCoresCnt", this.DefendHostCoresCnt);
            this.SetParamSimple(map, prefix + "TrialCoresCnt", this.TrialCoresCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

