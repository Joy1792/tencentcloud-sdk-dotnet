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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NativeNodePoolInfo : AbstractModel
    {
        
        /// <summary>
        /// 伸缩配置
        /// </summary>
        [JsonProperty("Scaling")]
        public MachineSetScaling Scaling{ get; set; }

        /// <summary>
        /// 子网列表
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 安全组列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 自动升级配置
        /// </summary>
        [JsonProperty("UpgradeSettings")]
        public MachineUpgradeSettings UpgradeSettings{ get; set; }

        /// <summary>
        /// 是否开启自愈能力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRepair")]
        public bool? AutoRepair{ get; set; }

        /// <summary>
        /// 节点计费类型
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 包年包月机型计费配置
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 系统盘配置
        /// </summary>
        [JsonProperty("SystemDisk")]
        public Disk SystemDisk{ get; set; }

        /// <summary>
        /// 密钥 ID 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// Machine 系统配置
        /// </summary>
        [JsonProperty("Management")]
        public ManagementConfig Management{ get; set; }

        /// <summary>
        /// 故障自愈规则名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckPolicyName")]
        public string HealthCheckPolicyName{ get; set; }

        /// <summary>
        /// 原生节点池hostName模式串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostNamePattern")]
        public string HostNamePattern{ get; set; }

        /// <summary>
        /// kubelet 自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KubeletArgs")]
        public string[] KubeletArgs{ get; set; }

        /// <summary>
        /// 预定义脚本
        /// </summary>
        [JsonProperty("Lifecycle")]
        public LifecycleConfig Lifecycle{ get; set; }

        /// <summary>
        /// 运行时根目录
        /// </summary>
        [JsonProperty("RuntimeRootDir")]
        public string RuntimeRootDir{ get; set; }

        /// <summary>
        /// 是否开启弹性伸缩
        /// </summary>
        [JsonProperty("EnableAutoscaling")]
        public bool? EnableAutoscaling{ get; set; }

        /// <summary>
        /// 机型列表
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// 期望节点数
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 就绪 Machine 个数
        /// </summary>
        [JsonProperty("ReadyReplicas")]
        public long? ReadyReplicas{ get; set; }

        /// <summary>
        /// 公网带宽设置
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 原生节点池数据盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 原生节点机型 Native, NativeCVM
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Scaling.", this.Scaling);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "UpgradeSettings.", this.UpgradeSettings);
            this.SetParamSimple(map, prefix + "AutoRepair", this.AutoRepair);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamObj(map, prefix + "Management.", this.Management);
            this.SetParamSimple(map, prefix + "HealthCheckPolicyName", this.HealthCheckPolicyName);
            this.SetParamSimple(map, prefix + "HostNamePattern", this.HostNamePattern);
            this.SetParamArraySimple(map, prefix + "KubeletArgs.", this.KubeletArgs);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamSimple(map, prefix + "RuntimeRootDir", this.RuntimeRootDir);
            this.SetParamSimple(map, prefix + "EnableAutoscaling", this.EnableAutoscaling);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "ReadyReplicas", this.ReadyReplicas);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
        }
    }
}

