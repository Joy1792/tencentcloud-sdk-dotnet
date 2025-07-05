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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 目标ES版本，支持：”6.4.3“, "6.8.2"，"7.5.1", "7.10.1", "7.14.2"
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// 是否只做升级检查，默认值为false
        /// </summary>
        [JsonProperty("CheckOnly")]
        public bool? CheckOnly{ get; set; }

        /// <summary>
        /// 目标商业特性版本：<li>oss 开源版</li><li>basic 基础版</li>当前仅在5.6.4升级6.x版本时使用，默认值为basic
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 6.8（及以上版本）基础版是否开启xpack security认证<li>1：不开启</li><li>2：开启</li>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// 升级方式：<li>scale 蓝绿变更</li><li>restart 滚动重启</li>默认值为scale
        /// </summary>
        [JsonProperty("UpgradeMode")]
        public string UpgradeMode{ get; set; }

        /// <summary>
        /// 升级版本前是否对集群进行备份，默认不备份
        /// </summary>
        [JsonProperty("CosBackup")]
        public bool? CosBackup{ get; set; }

        /// <summary>
        /// 滚动模式时，是否跳过检查，进行强制重启。默认值为false
        /// </summary>
        [JsonProperty("SkipCheckForceRestart")]
        public bool? SkipCheckForceRestart{ get; set; }

        /// <summary>
        /// cvm延迟上架参数
        /// </summary>
        [JsonProperty("CvmDelayOnlineTime")]
        public ulong? CvmDelayOnlineTime{ get; set; }

        /// <summary>
        /// 分片迁移并发数
        /// </summary>
        [JsonProperty("ShardAllocationConcurrents")]
        public ulong? ShardAllocationConcurrents{ get; set; }

        /// <summary>
        /// 分片迁移并发速度
        /// </summary>
        [JsonProperty("ShardAllocationBytes")]
        public ulong? ShardAllocationBytes{ get; set; }

        /// <summary>
        /// 是否开启置放群组异步任务
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// 置放群组异步任务时间段
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "CheckOnly", this.CheckOnly);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "UpgradeMode", this.UpgradeMode);
            this.SetParamSimple(map, prefix + "CosBackup", this.CosBackup);
            this.SetParamSimple(map, prefix + "SkipCheckForceRestart", this.SkipCheckForceRestart);
            this.SetParamSimple(map, prefix + "CvmDelayOnlineTime", this.CvmDelayOnlineTime);
            this.SetParamSimple(map, prefix + "ShardAllocationConcurrents", this.ShardAllocationConcurrents);
            this.SetParamSimple(map, prefix + "ShardAllocationBytes", this.ShardAllocationBytes);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
        }
    }
}

