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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFunctionResponse : AbstractModel
    {
        
        /// <summary>
        /// 函数的最后修改时间
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// 函数的代码
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// 函数的描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数的触发器列表
        /// </summary>
        [JsonProperty("Triggers")]
        public Trigger[] Triggers{ get; set; }

        /// <summary>
        /// 函数的入口
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// 函数代码大小
        /// </summary>
        [JsonProperty("CodeSize")]
        public long? CodeSize{ get; set; }

        /// <summary>
        /// 函数的超时时间
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数的版本
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// 函数的最大可用内存
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数的运行环境
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数的私有网络
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 是否使用GPU
        /// </summary>
        [JsonProperty("UseGpu")]
        public string UseGpu{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 代码是否正确
        /// </summary>
        [JsonProperty("CodeResult")]
        public string CodeResult{ get; set; }

        /// <summary>
        /// 代码错误信息
        /// </summary>
        [JsonProperty("CodeError")]
        public string CodeError{ get; set; }

        /// <summary>
        /// 代码错误码
        /// </summary>
        [JsonProperty("ErrNo")]
        public long? ErrNo{ get; set; }

        /// <summary>
        /// 函数的命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数绑定的角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 是否自动安装依赖
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// 函数状态，状态值及流转[参考说明](https://cloud.tencent.com/document/product/583/115197)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 日志投递到的Cls日志集
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 日志投递到的Cls Topic
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 函数ID
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 函数的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// EipConfig配置
        /// </summary>
        [JsonProperty("EipConfig")]
        public EipOutConfig EipConfig{ get; set; }

        /// <summary>
        /// 域名信息
        /// </summary>
        [JsonProperty("AccessInfo")]
        public AccessInfo AccessInfo{ get; set; }

        /// <summary>
        /// 函数类型，取值为HTTP或者Event
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 是否启用L5
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// 函数关联的Layer版本信息
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionInfo[] Layers{ get; set; }

        /// <summary>
        /// 函数关联的死信队列信息
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// 函数创建回见
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 公网访问配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigOut PublicNetConfig{ get; set; }

        /// <summary>
        /// 是否启用Ons
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnsEnable")]
        public string OnsEnable{ get; set; }

        /// <summary>
        /// 文件系统配置参数，用于云函数挂载文件系统
        /// </summary>
        [JsonProperty("CfsConfig")]
        public CfsConfig CfsConfig{ get; set; }

        /// <summary>
        /// 函数的计费状态，状态值[参考此处](https://cloud.tencent.com/document/product/583/47175#.E5.87.BD.E6.95.B0.E8.AE.A1.E8.B4.B9.E7.8A.B6.E6.80.81)
        /// </summary>
        [JsonProperty("AvailableStatus")]
        public string AvailableStatus{ get; set; }

        /// <summary>
        /// 函数版本
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 函数初始化超时时间
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// 函数状态失败原因
        /// </summary>
        [JsonProperty("StatusReasons")]
        public StatusReason[] StatusReasons{ get; set; }

        /// <summary>
        /// 是否开启异步属性
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// 是否开启事件追踪
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }

        /// <summary>
        /// 镜像配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageConfig")]
        public ImageConfig ImageConfig{ get; set; }

        /// <summary>
        /// HTTP函数支持的访问协议。当前支持WebSockets协议。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// HTTP函数配置ProtocolType访问协议，当前协议配置的参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolParams")]
        public ProtocolParams ProtocolParams{ get; set; }

        /// <summary>
        /// 是否开启DNS缓存
        /// </summary>
        [JsonProperty("DnsCache")]
        public string DnsCache{ get; set; }

        /// <summary>
        /// 内网访问配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntranetConfig")]
        public IntranetConfigOut IntranetConfig{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "CodeSize", this.CodeSize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "UseGpu", this.UseGpu);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "CodeResult", this.CodeResult);
            this.SetParamSimple(map, prefix + "CodeError", this.CodeError);
            this.SetParamSimple(map, prefix + "ErrNo", this.ErrNo);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EipConfig.", this.EipConfig);
            this.SetParamObj(map, prefix + "AccessInfo.", this.AccessInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamSimple(map, prefix + "OnsEnable", this.OnsEnable);
            this.SetParamObj(map, prefix + "CfsConfig.", this.CfsConfig);
            this.SetParamSimple(map, prefix + "AvailableStatus", this.AvailableStatus);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamArrayObj(map, prefix + "StatusReasons.", this.StatusReasons);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
            this.SetParamObj(map, prefix + "ImageConfig.", this.ImageConfig);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamObj(map, prefix + "ProtocolParams.", this.ProtocolParams);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamObj(map, prefix + "IntranetConfig.", this.IntranetConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

