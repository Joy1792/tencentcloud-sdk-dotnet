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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecuteScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警伸缩策略ID，不支持目标追踪策略。可通过 [DescribeScalingPolicies](https://cloud.tencent.com/document/api/377/33178) 接口返回的 `ScalingPolicyType ` 参数获取告警策略类型。
        /// </summary>
        [JsonProperty("AutoScalingPolicyId")]
        public string AutoScalingPolicyId{ get; set; }

        /// <summary>
        /// 是否检查伸缩组活动处于冷却时间内，默认值为false
        /// </summary>
        [JsonProperty("HonorCooldown")]
        public bool? HonorCooldown{ get; set; }

        /// <summary>
        /// 执行伸缩策略的触发来源，取值包括 API 和 CLOUD_MONITOR，默认值为 API。CLOUD_MONITOR 专门供云监控触发调用。
        /// </summary>
        [JsonProperty("TriggerSource")]
        public string TriggerSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingPolicyId", this.AutoScalingPolicyId);
            this.SetParamSimple(map, prefix + "HonorCooldown", this.HonorCooldown);
            this.SetParamSimple(map, prefix + "TriggerSource", this.TriggerSource);
        }
    }
}

