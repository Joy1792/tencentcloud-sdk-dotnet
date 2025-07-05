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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例状态：
        /// PENDING：表示创建中
        /// LAUNCH_FAILED：表示创建失败
        /// RUNNING：表示运行中
        /// ARREARS：表示待回收
        /// STOPPED_NO_CHARGE：表示关机不收费
        /// TERMINATING：表示销毁中
        /// TERMINATED：表示已销毁
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 算力套餐名称
        /// </summary>
        [JsonProperty("BundleName")]
        public string BundleName{ get; set; }

        /// <summary>
        /// 实例所包含的GPU卡数
        /// </summary>
        [JsonProperty("GPUCount")]
        public ulong? GPUCount{ get; set; }

        /// <summary>
        /// 算力
        /// </summary>
        [JsonProperty("GPUPerformance")]
        public string GPUPerformance{ get; set; }

        /// <summary>
        /// 显存，单位：GB
        /// </summary>
        [JsonProperty("GPUMemory")]
        public string GPUMemory{ get; set; }

        /// <summary>
        /// CPU核数，单位：核
        /// </summary>
        [JsonProperty("CPU")]
        public string CPU{ get; set; }

        /// <summary>
        /// 内存，单位：GB
        /// </summary>
        [JsonProperty("Memory")]
        public string Memory{ get; set; }

        /// <summary>
        /// 系统盘数据
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 内网ip地址
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 公网ip地址
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 实例最新操作
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// 实例最新操作状态：
        /// SUCCESS：表示操作成功
        /// OPERATING：表示操作执行中
        /// FAILED：表示操作失败
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// 实例创建时间，时间格式："YYYY-MM-DD HH:MM:SS"
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 公网出带宽上限，默认10Mbps，单位：Mbps
        /// </summary>
        [JsonProperty("MaxOutBandwidth")]
        public string MaxOutBandwidth{ get; set; }

        /// <summary>
        /// 每月免费流量，默认500G，单位：GB
        /// </summary>
        [JsonProperty("MaxFreeTraffic")]
        public string MaxFreeTraffic{ get; set; }

        /// <summary>
        /// 应用配置环境
        /// </summary>
        [JsonProperty("ConfigurationEnvironment")]
        public string ConfigurationEnvironment{ get; set; }

        /// <summary>
        /// 实例包含的登录服务详情
        /// </summary>
        [JsonProperty("LoginServices")]
        public LoginService[] LoginServices{ get; set; }

        /// <summary>
        /// 应用服务的操作系统类型；参数：linux、windows
        /// </summary>
        [JsonProperty("OSType")]
        public string OSType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "BundleName", this.BundleName);
            this.SetParamSimple(map, prefix + "GPUCount", this.GPUCount);
            this.SetParamSimple(map, prefix + "GPUPerformance", this.GPUPerformance);
            this.SetParamSimple(map, prefix + "GPUMemory", this.GPUMemory);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MaxOutBandwidth", this.MaxOutBandwidth);
            this.SetParamSimple(map, prefix + "MaxFreeTraffic", this.MaxFreeTraffic);
            this.SetParamSimple(map, prefix + "ConfigurationEnvironment", this.ConfigurationEnvironment);
            this.SetParamArrayObj(map, prefix + "LoginServices.", this.LoginServices);
            this.SetParamSimple(map, prefix + "OSType", this.OSType);
        }
    }
}

