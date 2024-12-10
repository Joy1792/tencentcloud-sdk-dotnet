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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 用户UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 实例所属VPC的UID
        /// </summary>
        [JsonProperty("VpcUid")]
        public string VpcUid{ get; set; }

        /// <summary>
        /// 实例所属子网的UID
        /// </summary>
        [JsonProperty("SubnetUid")]
        public string SubnetUid{ get; set; }

        /// <summary>
        /// 实例状态，0:处理中,1:正常,-1:停止,-2:销毁中,-3:已销毁, -4:隔离中,2:创建集群时初始化中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 自动续费标识。取值范围：
        /// RENEW_FLAG_AUTO：自动续费  
        /// RENEW_FLAG_MANUAL：不自动续费
        /// 默认取值：
        /// RENEW_FLAG_DEFAULT：不自动续费
        /// 若该参数指定为 RENEW_FLAG_AUTO，在账户余额充足的情况下，实例到期后将按月自动续费。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：  PREPAID：表示预付费，即包年包月  POSTPAID_BY_HOUR：表示后付费，即按量计费  CDHPAID：CDH付费，即只对CDH计费，不对CDH上的实例计费。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 包年包月购买时长,单位:月
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// 节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点个数
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 节点CPU核数
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// 节点内存大小，单位GB
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 节点磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 节点磁盘大小，单位GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// ES域名
        /// </summary>
        [JsonProperty("EsDomain")]
        public string EsDomain{ get; set; }

        /// <summary>
        /// ES VIP
        /// </summary>
        [JsonProperty("EsVip")]
        public string EsVip{ get; set; }

        /// <summary>
        /// ES端口
        /// </summary>
        [JsonProperty("EsPort")]
        public ulong? EsPort{ get; set; }

        /// <summary>
        /// Kibana访问url
        /// </summary>
        [JsonProperty("KibanaUrl")]
        public string KibanaUrl{ get; set; }

        /// <summary>
        /// ES版本号
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// ES配置项
        /// </summary>
        [JsonProperty("EsConfig")]
        public string EsConfig{ get; set; }

        /// <summary>
        /// Kibana访问控制配置
        /// </summary>
        [JsonProperty("EsAcl")]
        public EsAcl EsAcl{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例最后修改操作时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 实例到期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 实例类型（实例类型标识，当前只有1,2两种）
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// Ik分词器配置
        /// </summary>
        [JsonProperty("IkConfig")]
        public EsDictionaryInfo IkConfig{ get; set; }

        /// <summary>
        /// 专用主节点配置
        /// </summary>
        [JsonProperty("MasterNodeInfo")]
        public MasterNodeInfo MasterNodeInfo{ get; set; }

        /// <summary>
        /// cos自动备份配置
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// 是否允许cos自动备份
        /// </summary>
        [JsonProperty("AllowCosBackup")]
        public bool? AllowCosBackup{ get; set; }

        /// <summary>
        /// 实例拥有的标签列表
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// License类型<li>oss：开源版</li><li>basic：基础版</li><li>platinum：白金版</li>默认值platinum
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 是否为冷热集群<li>true: 冷热集群</li><li>false: 非冷热集群</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableHotWarmMode")]
        public bool? EnableHotWarmMode{ get; set; }

        /// <summary>
        /// 温节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmNodeType")]
        public string WarmNodeType{ get; set; }

        /// <summary>
        /// 温节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmNodeNum")]
        public ulong? WarmNodeNum{ get; set; }

        /// <summary>
        /// 温节点CPU核数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmCpuNum")]
        public ulong? WarmCpuNum{ get; set; }

        /// <summary>
        /// 温节点内存内存大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmMemSize")]
        public ulong? WarmMemSize{ get; set; }

        /// <summary>
        /// 温节点磁盘类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmDiskType")]
        public string WarmDiskType{ get; set; }

        /// <summary>
        /// 温节点磁盘大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmDiskSize")]
        public ulong? WarmDiskSize{ get; set; }

        /// <summary>
        /// 集群节点信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// Es公网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsPublicUrl")]
        public string EsPublicUrl{ get; set; }

        /// <summary>
        /// 多可用区网络信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// 部署模式<li>0：单可用区</li><li>1：多可用区，北京、上海、上海金融、广州、南京、香港、新加坡、法兰克福（白名单控制）</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }

        /// <summary>
        /// ES公网访问状态<li>OPEN：开启</li><li>CLOSE：关闭</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAccess")]
        public string PublicAccess{ get; set; }

        /// <summary>
        /// ES公网访问控制配置
        /// </summary>
        [JsonProperty("EsPublicAcl")]
        public EsAcl EsPublicAcl{ get; set; }

        /// <summary>
        /// Kibana内网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPrivateUrl")]
        public string KibanaPrivateUrl{ get; set; }

        /// <summary>
        /// Kibana公网访问状态<li>OPEN：开启</li><li>CLOSE：关闭</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPublicAccess")]
        public string KibanaPublicAccess{ get; set; }

        /// <summary>
        /// Kibana内网访问状态<li>OPEN：开启</li><li>CLOSE：关闭</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPrivateAccess")]
        public string KibanaPrivateAccess{ get; set; }

        /// <summary>
        /// 6.8（及以上版本）基础版是否开启xpack security认证<li>1：不开启</li><li>2：开启</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityType")]
        public ulong? SecurityType{ get; set; }

        /// <summary>
        /// 场景化模板类型：0、不开启；1、通用场景；2、日志场景；3、搜索场景
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// Kibana配置项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaConfig")]
        public string KibanaConfig{ get; set; }

        /// <summary>
        /// Kibana节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaNodeInfo")]
        public KibanaNodeInfo KibanaNodeInfo{ get; set; }

        /// <summary>
        /// 可视化节点配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// JDK类型，oracle或kona
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Jdk")]
        public string Jdk{ get; set; }

        /// <summary>
        /// 集群网络通讯协议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 安全组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// 冷节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdNodeType")]
        public string ColdNodeType{ get; set; }

        /// <summary>
        /// 冷节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdNodeNum")]
        public ulong? ColdNodeNum{ get; set; }

        /// <summary>
        /// 冷节点CPU核数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdCpuNum")]
        public ulong? ColdCpuNum{ get; set; }

        /// <summary>
        /// 冷节点内存大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdMemSize")]
        public ulong? ColdMemSize{ get; set; }

        /// <summary>
        /// 冷节点磁盘类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdDiskType")]
        public string ColdDiskType{ get; set; }

        /// <summary>
        /// 冷节点磁盘大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdDiskSize")]
        public ulong? ColdDiskSize{ get; set; }

        /// <summary>
        /// 冻节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenNodeType")]
        public string FrozenNodeType{ get; set; }

        /// <summary>
        /// 冻节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenNodeNum")]
        public ulong? FrozenNodeNum{ get; set; }

        /// <summary>
        /// 冻节点CPU核数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenCpuNum")]
        public ulong? FrozenCpuNum{ get; set; }

        /// <summary>
        /// 冻节点内存大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenMemSize")]
        public ulong? FrozenMemSize{ get; set; }

        /// <summary>
        /// 冻节点磁盘类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenDiskType")]
        public string FrozenDiskType{ get; set; }

        /// <summary>
        /// 冻节点磁盘大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenDiskSize")]
        public ulong? FrozenDiskSize{ get; set; }

        /// <summary>
        /// 集群健康状态 -1 未知；0 Green; 1 Yellow; 2 Red
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthStatus")]
        public long? HealthStatus{ get; set; }

        /// <summary>
        /// https集群内网url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsPrivateUrl")]
        public string EsPrivateUrl{ get; set; }

        /// <summary>
        /// https集群内网域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsPrivateDomain")]
        public string EsPrivateDomain{ get; set; }

        /// <summary>
        /// 集群的配置组信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsConfigSets")]
        public EsConfigSetInfo[] EsConfigSets{ get; set; }

        /// <summary>
        /// 集群可维护时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDuration OperationDuration{ get; set; }

        /// <summary>
        /// web节点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionalWebServiceInfos")]
        public OptionalWebServiceInfo[] OptionalWebServiceInfos{ get; set; }

        /// <summary>
        /// 自治索引开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoIndexEnabled")]
        public bool? AutoIndexEnabled{ get; set; }

        /// <summary>
        /// 是否支持存储计算分离
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableHybridStorage")]
        public bool? EnableHybridStorage{ get; set; }

        /// <summary>
        /// 流程进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessPercent")]
        public float? ProcessPercent{ get; set; }

        /// <summary>
        /// Kibana的alerting外网告警策略<li>OPEN：开启</li><li>CLOSE：关闭</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaAlteringPublicAccess")]
        public string KibanaAlteringPublicAccess{ get; set; }

        /// <summary>
        /// 本月是否有内核可以更新：false-无，true-有
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasKernelUpgrade")]
        public bool? HasKernelUpgrade{ get; set; }

        /// <summary>
        /// cdcId，使用cdc子网时传递
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// kibana内网vip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPrivateVip")]
        public string KibanaPrivateVip{ get; set; }

        /// <summary>
        /// 自定义kibana内网url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomKibanaPrivateUrl")]
        public string CustomKibanaPrivateUrl{ get; set; }

        /// <summary>
        /// 节点出站访问详细信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutboundPublicAcls")]
        public OutboundPublicAcl[] OutboundPublicAcls{ get; set; }

        /// <summary>
        /// 网络连接方案
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetConnectScheme")]
        public string NetConnectScheme{ get; set; }

        /// <summary>
        /// 置放群组相关参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupAffinity")]
        public ulong? DisasterRecoverGroupAffinity{ get; set; }

        /// <summary>
        /// 子产品ID枚举值： 开源版："sp_es_io2"， 基础版："sp_es_basic"，白金版："sp_es_platinum"，企业版："sp_es_enterprise"，CDC白金版："sp_es_cdc_platinum"，日志增强版："sp_es_enlogging"，tsearch："sp_tsearch_io2"，logstash："sp_es_logstash" ，可以为空，为空的时候后台取LicenseType映射该字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 存算分离cos用量，单位M
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucketStorageSize")]
        public ulong? CosBucketStorageSize{ get; set; }

        /// <summary>
        /// 读写分离模式：0-不开启，1-本地读写分离，2-远端读写分离
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }

        /// <summary>
        /// 是否有置放群组异步调度任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// 异步调度任务的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// 开启集群保护：OPEN-开启，CLOSE-关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDestroyProtection")]
        public string EnableDestroyProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "VpcUid", this.VpcUid);
            this.SetParamSimple(map, prefix + "SubnetUid", this.SubnetUid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ChargePeriod", this.ChargePeriod);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "EsDomain", this.EsDomain);
            this.SetParamSimple(map, prefix + "EsVip", this.EsVip);
            this.SetParamSimple(map, prefix + "EsPort", this.EsPort);
            this.SetParamSimple(map, prefix + "KibanaUrl", this.KibanaUrl);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "EsConfig", this.EsConfig);
            this.SetParamObj(map, prefix + "EsAcl.", this.EsAcl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "IkConfig.", this.IkConfig);
            this.SetParamObj(map, prefix + "MasterNodeInfo.", this.MasterNodeInfo);
            this.SetParamObj(map, prefix + "CosBackup.", this.CosBackup);
            this.SetParamSimple(map, prefix + "AllowCosBackup", this.AllowCosBackup);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "EnableHotWarmMode", this.EnableHotWarmMode);
            this.SetParamSimple(map, prefix + "WarmNodeType", this.WarmNodeType);
            this.SetParamSimple(map, prefix + "WarmNodeNum", this.WarmNodeNum);
            this.SetParamSimple(map, prefix + "WarmCpuNum", this.WarmCpuNum);
            this.SetParamSimple(map, prefix + "WarmMemSize", this.WarmMemSize);
            this.SetParamSimple(map, prefix + "WarmDiskType", this.WarmDiskType);
            this.SetParamSimple(map, prefix + "WarmDiskSize", this.WarmDiskSize);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamSimple(map, prefix + "EsPublicUrl", this.EsPublicUrl);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "PublicAccess", this.PublicAccess);
            this.SetParamObj(map, prefix + "EsPublicAcl.", this.EsPublicAcl);
            this.SetParamSimple(map, prefix + "KibanaPrivateUrl", this.KibanaPrivateUrl);
            this.SetParamSimple(map, prefix + "KibanaPublicAccess", this.KibanaPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateAccess", this.KibanaPrivateAccess);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "KibanaConfig", this.KibanaConfig);
            this.SetParamObj(map, prefix + "KibanaNodeInfo.", this.KibanaNodeInfo);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamSimple(map, prefix + "Jdk", this.Jdk);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "ColdNodeType", this.ColdNodeType);
            this.SetParamSimple(map, prefix + "ColdNodeNum", this.ColdNodeNum);
            this.SetParamSimple(map, prefix + "ColdCpuNum", this.ColdCpuNum);
            this.SetParamSimple(map, prefix + "ColdMemSize", this.ColdMemSize);
            this.SetParamSimple(map, prefix + "ColdDiskType", this.ColdDiskType);
            this.SetParamSimple(map, prefix + "ColdDiskSize", this.ColdDiskSize);
            this.SetParamSimple(map, prefix + "FrozenNodeType", this.FrozenNodeType);
            this.SetParamSimple(map, prefix + "FrozenNodeNum", this.FrozenNodeNum);
            this.SetParamSimple(map, prefix + "FrozenCpuNum", this.FrozenCpuNum);
            this.SetParamSimple(map, prefix + "FrozenMemSize", this.FrozenMemSize);
            this.SetParamSimple(map, prefix + "FrozenDiskType", this.FrozenDiskType);
            this.SetParamSimple(map, prefix + "FrozenDiskSize", this.FrozenDiskSize);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "EsPrivateUrl", this.EsPrivateUrl);
            this.SetParamSimple(map, prefix + "EsPrivateDomain", this.EsPrivateDomain);
            this.SetParamArrayObj(map, prefix + "EsConfigSets.", this.EsConfigSets);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamArrayObj(map, prefix + "OptionalWebServiceInfos.", this.OptionalWebServiceInfos);
            this.SetParamSimple(map, prefix + "AutoIndexEnabled", this.AutoIndexEnabled);
            this.SetParamSimple(map, prefix + "EnableHybridStorage", this.EnableHybridStorage);
            this.SetParamSimple(map, prefix + "ProcessPercent", this.ProcessPercent);
            this.SetParamSimple(map, prefix + "KibanaAlteringPublicAccess", this.KibanaAlteringPublicAccess);
            this.SetParamSimple(map, prefix + "HasKernelUpgrade", this.HasKernelUpgrade);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "KibanaPrivateVip", this.KibanaPrivateVip);
            this.SetParamSimple(map, prefix + "CustomKibanaPrivateUrl", this.CustomKibanaPrivateUrl);
            this.SetParamArrayObj(map, prefix + "OutboundPublicAcls.", this.OutboundPublicAcls);
            this.SetParamSimple(map, prefix + "NetConnectScheme", this.NetConnectScheme);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupAffinity", this.DisasterRecoverGroupAffinity);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "CosBucketStorageSize", this.CosBucketStorageSize);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamSimple(map, prefix + "EnableDestroyProtection", this.EnableDestroyProtection);
        }
    }
}

