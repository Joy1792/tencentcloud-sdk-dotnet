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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Tactic : AbstractModel
    {
        
        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 是否自动执行策略
        /// </summary>
        [JsonProperty("IsAuto")]
        public long? IsAuto{ get; set; }

        /// <summary>
        /// 设备上报信息间隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PingInterval")]
        public long? PingInterval{ get; set; }

        /// <summary>
        /// 是否开启弱信号检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWeak")]
        public long? IsWeak{ get; set; }

        /// <summary>
        /// 弱信号阈值（-dbm）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeakThreshold")]
        public long? WeakThreshold{ get; set; }

        /// <summary>
        /// 忘了时延切换
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDelay")]
        public long? IsDelay{ get; set; }

        /// <summary>
        /// 时延阈值（ms）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayThreshold")]
        public long? DelayThreshold{ get; set; }

        /// <summary>
        /// 是否开启假信号检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// 假信号检测IP字符串，用逗号分隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeIP")]
        public string FakeIP{ get; set; }

        /// <summary>
        /// 假信号检测间隔（s）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeInterval")]
        public long? FakeInterval{ get; set; }

        /// <summary>
        /// 是否开启网络制式检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNet")]
        public long? IsNet{ get; set; }

        /// <summary>
        /// 网络回落制式 1: 2G、 2: 3G 、 3: 2/3G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Network")]
        public long? Network{ get; set; }

        /// <summary>
        /// 是否开启移动检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsMove")]
        public long? IsMove{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否开启最优先运营商
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPriorityTele")]
        public long? IsPriorityTele{ get; set; }

        /// <summary>
        /// 最优先运营商 1 移动、 2 联通、 3 电信 4 上次在线运营商
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriorityTele")]
        public long? PriorityTele{ get; set; }

        /// <summary>
        /// 是否开启最不优先运营商
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsBottomTele")]
        public long? IsBottomTele{ get; set; }

        /// <summary>
        /// 最不优先运营商 1 移动、 2 联通、 3 电信
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BottomTele")]
        public long? BottomTele{ get; set; }

        /// <summary>
        /// 是否开启最优先信号选取策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsBestSignal")]
        public long? IsBestSignal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "IsAuto", this.IsAuto);
            this.SetParamSimple(map, prefix + "PingInterval", this.PingInterval);
            this.SetParamSimple(map, prefix + "IsWeak", this.IsWeak);
            this.SetParamSimple(map, prefix + "WeakThreshold", this.WeakThreshold);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamSimple(map, prefix + "DelayThreshold", this.DelayThreshold);
            this.SetParamSimple(map, prefix + "IsFake", this.IsFake);
            this.SetParamSimple(map, prefix + "FakeIP", this.FakeIP);
            this.SetParamSimple(map, prefix + "FakeInterval", this.FakeInterval);
            this.SetParamSimple(map, prefix + "IsNet", this.IsNet);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamSimple(map, prefix + "IsMove", this.IsMove);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsPriorityTele", this.IsPriorityTele);
            this.SetParamSimple(map, prefix + "PriorityTele", this.PriorityTele);
            this.SetParamSimple(map, prefix + "IsBottomTele", this.IsBottomTele);
            this.SetParamSimple(map, prefix + "BottomTele", this.BottomTele);
            this.SetParamSimple(map, prefix + "IsBestSignal", this.IsBestSignal);
        }
    }
}

