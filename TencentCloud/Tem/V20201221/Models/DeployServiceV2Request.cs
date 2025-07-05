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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployServiceV2Request : AbstractModel
    {
        
        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 容器端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public ulong? ContainerPort{ get; set; }

        /// <summary>
        /// 初始化 pod 数
        /// </summary>
        [JsonProperty("InitPodNum")]
        public ulong? InitPodNum{ get; set; }

        /// <summary>
        /// cpu规格
        /// </summary>
        [JsonProperty("CpuSpec")]
        public float? CpuSpec{ get; set; }

        /// <summary>
        /// 内存规格
        /// </summary>
        [JsonProperty("MemorySpec")]
        public float? MemorySpec{ get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 镜像仓库
        /// </summary>
        [JsonProperty("ImgRepo")]
        public string ImgRepo{ get; set; }

        /// <summary>
        /// 版本描述信息
        /// </summary>
        [JsonProperty("VersionDesc")]
        public string VersionDesc{ get; set; }

        /// <summary>
        /// 启动参数
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 弹性伸缩配置，不传默认不启用弹性伸缩配置
        /// </summary>
        [JsonProperty("EsInfo")]
        public EsInfo EsInfo{ get; set; }

        /// <summary>
        /// 环境变量配置
        /// </summary>
        [JsonProperty("EnvConf")]
        public Pair[] EnvConf{ get; set; }

        /// <summary>
        /// 日志配置
        /// </summary>
        [JsonProperty("LogConfs")]
        public string[] LogConfs{ get; set; }

        /// <summary>
        /// 数据卷配置
        /// </summary>
        [JsonProperty("StorageConfs")]
        public StorageConf[] StorageConfs{ get; set; }

        /// <summary>
        /// 数据卷挂载配置
        /// </summary>
        [JsonProperty("StorageMountConfs")]
        public StorageMountConf[] StorageMountConfs{ get; set; }

        /// <summary>
        /// 部署类型。
        /// - JAR：通过 jar 包部署
        /// - WAR：通过 war 包部署
        /// - IMAGE：通过镜像部署
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// 部署类型为 IMAGE 时，该参数表示镜像 tag。
        /// 部署类型为 JAR/WAR 时，该参数表示包版本号。
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// 包名。使用 JAR 包或者 WAR 包部署的时候必填。
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// JDK 版本。
        /// - KONA：使用 kona jdk。
        /// - OPEN：使用 open jdk。
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// 安全组ID s
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 日志输出配置
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 镜像命令
        /// </summary>
        [JsonProperty("ImageCommand")]
        public string ImageCommand{ get; set; }

        /// <summary>
        /// 镜像命令参数
        /// </summary>
        [JsonProperty("ImageArgs")]
        public string[] ImageArgs{ get; set; }

        /// <summary>
        /// 服务端口映射
        /// </summary>
        [JsonProperty("PortMappings")]
        public PortMapping[] PortMappings{ get; set; }

        /// <summary>
        /// 是否添加默认注册中心配置
        /// </summary>
        [JsonProperty("UseRegistryDefaultConfig")]
        public bool? UseRegistryDefaultConfig{ get; set; }

        /// <summary>
        /// 挂载配置信息
        /// </summary>
        [JsonProperty("SettingConfs")]
        public MountedSettingConf[] SettingConfs{ get; set; }

        /// <summary>
        /// eks 访问设置
        /// </summary>
        [JsonProperty("EksService")]
        public EksService EksService{ get; set; }

        /// <summary>
        /// 要回滚到的历史版本id
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 启动后执行的脚本
        /// </summary>
        [JsonProperty("PostStart")]
        public string PostStart{ get; set; }

        /// <summary>
        /// 停止前执行的脚本
        /// </summary>
        [JsonProperty("PreStop")]
        public string PreStop{ get; set; }

        /// <summary>
        /// 分批发布策略配置
        /// </summary>
        [JsonProperty("DeployStrategyConf")]
        public DeployStrategyConf DeployStrategyConf{ get; set; }

        /// <summary>
        /// 存活探针配置
        /// </summary>
        [JsonProperty("Liveness")]
        public HealthCheckConfig Liveness{ get; set; }

        /// <summary>
        /// 就绪探针配置
        /// </summary>
        [JsonProperty("Readiness")]
        public HealthCheckConfig Readiness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "InitPodNum", this.InitPodNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "ImgRepo", this.ImgRepo);
            this.SetParamSimple(map, prefix + "VersionDesc", this.VersionDesc);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamArrayObj(map, prefix + "EnvConf.", this.EnvConf);
            this.SetParamArraySimple(map, prefix + "LogConfs.", this.LogConfs);
            this.SetParamArrayObj(map, prefix + "StorageConfs.", this.StorageConfs);
            this.SetParamArrayObj(map, prefix + "StorageMountConfs.", this.StorageMountConfs);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PkgName", this.PkgName);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ImageCommand", this.ImageCommand);
            this.SetParamArraySimple(map, prefix + "ImageArgs.", this.ImageArgs);
            this.SetParamArrayObj(map, prefix + "PortMappings.", this.PortMappings);
            this.SetParamSimple(map, prefix + "UseRegistryDefaultConfig", this.UseRegistryDefaultConfig);
            this.SetParamArrayObj(map, prefix + "SettingConfs.", this.SettingConfs);
            this.SetParamObj(map, prefix + "EksService.", this.EksService);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "PostStart", this.PostStart);
            this.SetParamSimple(map, prefix + "PreStop", this.PreStop);
            this.SetParamObj(map, prefix + "DeployStrategyConf.", this.DeployStrategyConf);
            this.SetParamObj(map, prefix + "Liveness.", this.Liveness);
            this.SetParamObj(map, prefix + "Readiness.", this.Readiness);
        }
    }
}

