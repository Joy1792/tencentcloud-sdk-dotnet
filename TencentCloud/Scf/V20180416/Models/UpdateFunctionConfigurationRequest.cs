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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFunctionConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 要修改的函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数描述。最大支持 1000 个英文字母、数字、空格、逗号和英文句号，支持中文
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数运行时内存大小，默认为 128 M，可选范64M、128 M-3072 M，以 128MB 为阶梯。
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数最长执行时间，单位为秒，可选值范 1-900 秒，默认为 3 秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数运行环境，创建时指定，目前不支持修改。
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 函数所属命名空间
        /// 默认值: default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数的私有网络配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 函数绑定的角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// [在线依赖安装](https://cloud.tencent.com/document/product/583/37920)，TRUE 表示安装，默认值为 FALSE。仅支持 Node.js 函数。
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// 日志投递到的cls日志集ID
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 日志投递到的cls Topic ID
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 在更新时是否同步发布新版本，默认为：FALSE，不发布新版本
        /// </summary>
        [JsonProperty("Publish")]
        public string Publish{ get; set; }

        /// <summary>
        /// 是否开启L5访问能力，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// 函数要关联的层版本列表，层的版本会按照在列表中顺序依次覆盖。
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionSimple[] Layers{ get; set; }

        /// <summary>
        /// 函数关联的死信队列信息
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// 公网访问配置
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigIn PublicNetConfig{ get; set; }

        /// <summary>
        /// 文件系统配置入参，用于云函数绑定CFS文件系统
        /// </summary>
        [JsonProperty("CfsConfig")]
        public CfsConfig CfsConfig{ get; set; }

        /// <summary>
        /// 函数初始化执行超时时间
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// HTTP函数配置ProtocolType访问协议，当前协议可配置的参数
        /// </summary>
        [JsonProperty("ProtocolParams")]
        public ProtocolParams ProtocolParams{ get; set; }

        /// <summary>
        /// 单实例多并发配置。只支持Web函数。
        /// </summary>
        [JsonProperty("InstanceConcurrencyConfig")]
        public InstanceConcurrencyConfig InstanceConcurrencyConfig{ get; set; }

        /// <summary>
        /// 是否开启Dns缓存能力。只支持EVENT函数。默认为FALSE，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("DnsCache")]
        public string DnsCache{ get; set; }

        /// <summary>
        /// 内网访问配置
        /// </summary>
        [JsonProperty("IntranetConfig")]
        public IntranetConfigIn IntranetConfig{ get; set; }

        /// <summary>
        /// 忽略系统日志上报
        /// </summary>
        [JsonProperty("IgnoreSysLog")]
        public bool? IgnoreSysLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Publish", this.Publish);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamObj(map, prefix + "CfsConfig.", this.CfsConfig);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamObj(map, prefix + "ProtocolParams.", this.ProtocolParams);
            this.SetParamObj(map, prefix + "InstanceConcurrencyConfig.", this.InstanceConcurrencyConfig);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamObj(map, prefix + "IntranetConfig.", this.IntranetConfig);
            this.SetParamSimple(map, prefix + "IgnoreSysLog", this.IgnoreSysLog);
        }
    }
}

