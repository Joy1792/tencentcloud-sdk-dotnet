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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterGroupSetItem : AbstractModel
    {
        
        /// <summary>
        /// clusterGroup 的 SerialId
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 账号 APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 主账号 UIN
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建账号 UIN
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// CU 数量
        /// </summary>
        [JsonProperty("CuNum")]
        public long? CuNum{ get; set; }

        /// <summary>
        /// CU 内存规格
        /// </summary>
        [JsonProperty("CuMem")]
        public long? CuMem{ get; set; }

        /// <summary>
        /// 集群状态, 1 未初始化,，3 初始化中，2 运行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后一次操作集群的时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 网络
        /// </summary>
        [JsonProperty("NetEnvironmentType")]
        public long? NetEnvironmentType{ get; set; }

        /// <summary>
        /// 空闲 CU
        /// </summary>
        [JsonProperty("FreeCuNum")]
        public long? FreeCuNum{ get; set; }

        /// <summary>
        /// 细粒度资源下的空闲CU
        /// </summary>
        [JsonProperty("FreeCu")]
        public float? FreeCu{ get; set; }

        /// <summary>
        /// 运行中CU
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 弹性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubEks")]
        public SubEks SubEks{ get; set; }

        /// <summary>
        /// 默认 "" 包销模式 "exclusiveSale"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingResourceMode")]
        public string BillingResourceMode{ get; set; }

        /// <summary>
        /// TotalCpu
        /// </summary>
        [JsonProperty("TotalCpu")]
        public float? TotalCpu{ get; set; }

        /// <summary>
        /// TotalMem
        /// </summary>
        [JsonProperty("TotalMem")]
        public float? TotalMem{ get; set; }

        /// <summary>
        /// RunningCpu
        /// </summary>
        [JsonProperty("RunningCpu")]
        public float? RunningCpu{ get; set; }

        /// <summary>
        /// RunningMem
        /// </summary>
        [JsonProperty("RunningMem")]
        public float? RunningMem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CuNum", this.CuNum);
            this.SetParamSimple(map, prefix + "CuMem", this.CuMem);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "NetEnvironmentType", this.NetEnvironmentType);
            this.SetParamSimple(map, prefix + "FreeCuNum", this.FreeCuNum);
            this.SetParamSimple(map, prefix + "FreeCu", this.FreeCu);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamObj(map, prefix + "SubEks.", this.SubEks);
            this.SetParamSimple(map, prefix + "BillingResourceMode", this.BillingResourceMode);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "RunningCpu", this.RunningCpu);
            this.SetParamSimple(map, prefix + "RunningMem", this.RunningMem);
        }
    }
}

