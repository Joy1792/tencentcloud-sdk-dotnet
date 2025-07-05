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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EstablishCloudBaseRunServerRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 是否开通外网访问
        /// </summary>
        [JsonProperty("IsPublic")]
        public bool? IsPublic{ get; set; }

        /// <summary>
        /// 镜像仓库
        /// </summary>
        [JsonProperty("ImageRepo")]
        public string ImageRepo{ get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// es信息
        /// </summary>
        [JsonProperty("EsInfo")]
        public CloudBaseEsInfo EsInfo{ get; set; }

        /// <summary>
        /// 日志类型; es/cls
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }

        /// <summary>
        /// 来源方（默认值：qcloud，微信侧来源miniapp)
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// vpc信息
        /// </summary>
        [JsonProperty("VpcInfo")]
        public CloudBaseRunVpcInfo VpcInfo{ get; set; }

        /// <summary>
        /// 0/1=允许公网访问;2=关闭公网访问
        /// </summary>
        [JsonProperty("PublicAccess")]
        public long? PublicAccess{ get; set; }

        /// <summary>
        /// OA PUBLIC MINIAPP VPC
        /// </summary>
        [JsonProperty("OpenAccessTypes")]
        public string[] OpenAccessTypes{ get; set; }

        /// <summary>
        /// 是否创建Path 0未传默认创建 1创建 2不创建
        /// </summary>
        [JsonProperty("IsCreatePath")]
        public long? IsCreatePath{ get; set; }

        /// <summary>
        /// 指定创建路径（如不存在，则创建。存在，则忽略）
        /// </summary>
        [JsonProperty("ServerPath")]
        public string ServerPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "ImageRepo", this.ImageRepo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "PublicAccess", this.PublicAccess);
            this.SetParamArraySimple(map, prefix + "OpenAccessTypes.", this.OpenAccessTypes);
            this.SetParamSimple(map, prefix + "IsCreatePath", this.IsCreatePath);
            this.SetParamSimple(map, prefix + "ServerPath", this.ServerPath);
        }
    }
}

