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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceAffectedAsset : AbstractModel
    {
        
        /// <summary>
        /// 为客户分配的唯一的资产项的ID。
        /// </summary>
        [JsonProperty("CustomerAssetId")]
        public ulong? CustomerAssetId{ get; set; }

        /// <summary>
        /// 资产项的名称。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产项的类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 检测状态
        /// 
        /// CHECK_INIT, 待检测
        /// 
        /// CHECK_RUNNING, 检测中
        /// 
        /// CHECK_FINISHED, 检测完成
        /// 
        /// CHECK_FAILED, 检测失败
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 上次检测的时间，格式为”YYYY-MM-DD HH:m::SS“。
        /// 
        /// 如果没有检测过，此处为”0000-00-00 00:00:00“。
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// 检测结果。取值为：
        /// 
        /// RESULT_FAILED: 未通过
        /// 
        /// RESULT_PASSED: 通过
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 镜像的tag
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// 检查项验证信息
        /// </summary>
        [JsonProperty("VerifyInfo")]
        public string VerifyInfo{ get; set; }

        /// <summary>
        /// 主机实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 镜像仓库信息
        /// </summary>
        [JsonProperty("ImageRegistryInfo")]
        public ImageRegistryInfo ImageRegistryInfo{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerAssetId", this.CustomerAssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "VerifyInfo", this.VerifyInfo);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "ImageRegistryInfo.", this.ImageRegistryInfo);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
        }
    }
}

