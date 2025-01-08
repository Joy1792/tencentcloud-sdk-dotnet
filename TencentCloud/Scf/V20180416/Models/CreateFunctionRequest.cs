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

    public class CreateFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// 创建的函数名称，函数名称支持26个英文字母大小写、数字、连接符和下划线，第一个字符只能以字母开头，最后一个字符不能为连接符或者下划线，名称长度2-60
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数代码. 注意：不能同时指定Cos、ZipFile或 DemoId。
        /// </summary>
        [JsonProperty("Code")]
        public Code Code{ get; set; }

        /// <summary>
        /// 函数处理方法名称，名称格式支持 "文件名称.方法名称" 形式（java 名称格式 包名.类名::方法名），文件名称和函数名称之间以"."隔开，文件名称和函数名称要求以字母开始和结尾，中间允许插入字母、数字、下划线和连接符，文件名称和函数名字的长度要求是 2-60 个字符
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// 函数描述,最大支持 1000 个英文字母、数字、空格、逗号、换行符和英文句号，支持中文
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数运行时内存大小，默认为 128M，可选范围 64、128MB-3072MB，并且以 128MB 为阶梯
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数最长执行时间，单位为秒，可选值范围 1-900 秒，默认为 3 秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 函数运行环境，默认Python2.7
        /// 目前支持的运行环境：
        /// - Python2.7
        /// - Python3.6
        /// - Python3.7
        /// - Python3.9
        /// - Python3.10
        /// - Nodejs6.10
        /// - Nodejs8.9
        /// - Nodejs10.15
        /// - Nodejs12.16
        /// - Nodejs14.18
        /// - Nodejs16.13
        /// - Nodejs18.15
        /// - Php5.6
        /// - Php7(7.2版本)
        /// - Php7.4
        /// - Php8.0
        /// - Go1
        /// - Java8
        /// - CustomRuntime
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的私有网络配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 函数所属命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

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
        /// 函数日志投递到的CLS LogsetID
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 函数日志投递到的CLS TopicID
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 函数类型，默认值为Event，创建触发器函数请填写Event，创建HTTP函数级服务请填写HTTP
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// CodeSource 代码来源，支持ZipFile, Cos, Demo 其中之一
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }

        /// <summary>
        /// 函数要关联的Layer版本列表，Layer会按照在列表中顺序依次覆盖。
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionSimple[] Layers{ get; set; }

        /// <summary>
        /// 死信队列参数
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// 公网访问配置
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigIn PublicNetConfig{ get; set; }

        /// <summary>
        /// 文件系统配置参数，用于云函数挂载文件系统
        /// </summary>
        [JsonProperty("CfsConfig")]
        public CfsConfig CfsConfig{ get; set; }

        /// <summary>
        /// 函数初始化超时时间，默认 65s，镜像部署函数默认 90s。
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// 函数 Tag 参数，以键值对数组形式传入
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否开启异步属性，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// 是否开启事件追踪，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }

        /// <summary>
        /// 是否自动创建cls索引，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("AutoDeployClsTopicIndex")]
        public string AutoDeployClsTopicIndex{ get; set; }

        /// <summary>
        /// 是否自动创建cls主题，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("AutoCreateClsTopic")]
        public string AutoCreateClsTopic{ get; set; }

        /// <summary>
        /// HTTP函数支持的访问协议。当前支持WebSockets协议，值为WS
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamObj(map, prefix + "CfsConfig.", this.CfsConfig);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
            this.SetParamSimple(map, prefix + "AutoDeployClsTopicIndex", this.AutoDeployClsTopicIndex);
            this.SetParamSimple(map, prefix + "AutoCreateClsTopic", this.AutoCreateClsTopic);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamObj(map, prefix + "ProtocolParams.", this.ProtocolParams);
            this.SetParamObj(map, prefix + "InstanceConcurrencyConfig.", this.InstanceConcurrencyConfig);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamObj(map, prefix + "IntranetConfig.", this.IntranetConfig);
        }
    }
}

