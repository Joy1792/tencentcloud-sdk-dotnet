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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoGroup : AbstractModel
    {
        
        /// <summary>
        /// 只读组模式，可选值为：alone-系统自动分配只读组；allinone-新建只读组；join-使用现有只读组。
        /// </summary>
        [JsonProperty("RoGroupMode")]
        public string RoGroupMode{ get; set; }

        /// <summary>
        /// 只读组 ID。
        /// 说明：若此数据结构在购买实例操作中被使用，则当只读组模式选择 join 时，此项为必填。
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// 只读组名称。
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// 是否启用延迟超限剔除功能，启用该功能后，只读实例与主实例的延迟超过延迟阈值，只读实例将被隔离。可选值：1-启用；0-不启用。
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// 延迟阈值。单位：秒。值范围：1-10000，整数。
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// 最少实例保留个数，若购买只读实例数量小于设置数量将不做剔除。
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// 读写权重分配模式，可选值：system-系统自动分配；custom-自定义。
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 该字段已经废弃，无意义。查看只读实例的权重，请查看 RoInstances 字段里的 Weight 值。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 只读组中的只读实例详情。
        /// </summary>
        [JsonProperty("RoInstances")]
        public RoInstanceInfo[] RoInstances{ get; set; }

        /// <summary>
        /// 只读组的内网 IP。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 只读组的内网端口号。
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 私有网络 ID。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 子网 ID。
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 只读组所在的地域。
        /// </summary>
        [JsonProperty("RoGroupRegion")]
        public string RoGroupRegion{ get; set; }

        /// <summary>
        /// 只读组所在的可用区。
        /// </summary>
        [JsonProperty("RoGroupZone")]
        public string RoGroupZone{ get; set; }

        /// <summary>
        /// 延迟复制时间。单位：秒。值范围：1-259200，整数。
        /// </summary>
        [JsonProperty("DelayReplicationTime")]
        public long? DelayReplicationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupMode", this.RoGroupMode);
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
            this.SetParamSimple(map, prefix + "RoGroupName", this.RoGroupName);
            this.SetParamSimple(map, prefix + "RoOfflineDelay", this.RoOfflineDelay);
            this.SetParamSimple(map, prefix + "RoMaxDelayTime", this.RoMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinRoInGroup", this.MinRoInGroup);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamArrayObj(map, prefix + "RoInstances.", this.RoInstances);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "RoGroupRegion", this.RoGroupRegion);
            this.SetParamSimple(map, prefix + "RoGroupZone", this.RoGroupZone);
            this.SetParamSimple(map, prefix + "DelayReplicationTime", this.DelayReplicationTime);
        }
    }
}

