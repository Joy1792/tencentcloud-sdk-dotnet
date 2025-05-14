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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamedComputeEnv : AbstractModel
    {
        
        /// <summary>
        /// 计算环境名称
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 计算节点期望个数，最大上限2000.
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public long? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// 计算环境描述
        /// </summary>
        [JsonProperty("EnvDescription")]
        public string EnvDescription{ get; set; }

        /// <summary>
        /// 计算环境管理类型，枚举如下：
        /// MANAGED: 由客户在Batch平台主动创建；
        /// THPC_QUEUE: 由THPC平台创建，关联THPC平台的集群队列。
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 计算环境具体参数
        /// </summary>
        [JsonProperty("EnvData")]
        public EnvData EnvData{ get; set; }

        /// <summary>
        /// 数据盘挂载选项
        /// </summary>
        [JsonProperty("MountDataDisks")]
        public MountDataDisk[] MountDataDisks{ get; set; }

        /// <summary>
        /// 授权信息
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// 输入映射信息
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// agent运行模式，适用于Windows系统
        /// </summary>
        [JsonProperty("AgentRunningMode")]
        public AgentRunningMode AgentRunningMode{ get; set; }

        /// <summary>
        /// 通知信息
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// 非活跃节点处理策略，默认“RECREATE”，即对于实例创建失败或异常退还的计算节点，定期重新创建实例资源。
        /// </summary>
        [JsonProperty("ActionIfComputeNodeInactive")]
        public string ActionIfComputeNodeInactive{ get; set; }

        /// <summary>
        /// 对于实例创建失败或异常退还的计算节点，定期重新创建实例资源的最大重试次数，最大值100，如果不设置的话，系统会设置一个默认值，当前为7
        /// </summary>
        [JsonProperty("ResourceMaxRetryCount")]
        public long? ResourceMaxRetryCount{ get; set; }

        /// <summary>
        /// 标签列表。通过指定该参数可以支持绑定标签到计算环境。每个计算环境最多绑定10个标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 表示通知信息的通知目标类型。
        /// 取值范围：CMQ，TDMQ_CMQ。
        /// CMQ:表示向腾讯云CMQ发送消息。
        /// TDMQ_CMQ：表示向腾讯云TDMQ_CMQ发送消息。<br/>默认值为CMQ。<br/>注：腾讯云计划于2022年6月前正式下线消息队列 CMQ，建议使用TDMQ_CMQ。参考文档：[CMQ迁移到TDMQ_CMQ](https://cloud.tencent.com/document/product/406/60860)
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public string NotificationTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "EnvDescription", this.EnvDescription);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
            this.SetParamArrayObj(map, prefix + "MountDataDisks.", this.MountDataDisks);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamObj(map, prefix + "AgentRunningMode.", this.AgentRunningMode);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "ActionIfComputeNodeInactive", this.ActionIfComputeNodeInactive);
            this.SetParamSimple(map, prefix + "ResourceMaxRetryCount", this.ResourceMaxRetryCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NotificationTarget", this.NotificationTarget);
        }
    }
}

