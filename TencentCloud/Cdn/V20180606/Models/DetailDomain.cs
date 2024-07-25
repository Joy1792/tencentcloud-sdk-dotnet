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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailDomain : AbstractModel
    {
        
        /// <summary>
        /// 域名 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 腾讯云账号ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 加速域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名对应的 CNAME 地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 加速服务状态
        /// rejected：域名审核未通过，域名备案过期/被注销导致
        /// processing：部署中
        /// closing：关闭中
        /// online：已启动
        /// offline：已关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 项目 ID，可前往腾讯云项目管理页面查看
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 加速域名业务类型
        /// web：网页小文件
        /// download：下载大文件
        /// media：音视频点播
        /// hybrid:  动静加速
        /// dynamic:  动态加速
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 域名创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 域名更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 源站配置
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// IP 黑白名单配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// IP 访问限频配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpFreqLimit")]
        public IpFreqLimit IpFreqLimit{ get; set; }

        /// <summary>
        /// 状态码缓存配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCodeCache")]
        public StatusCodeCache StatusCodeCache{ get; set; }

        /// <summary>
        /// 智能压缩配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// 带宽封顶配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthAlert")]
        public BandwidthAlert BandwidthAlert{ get; set; }

        /// <summary>
        /// Range 回源配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeOriginPull")]
        public RangeOriginPull RangeOriginPull{ get; set; }

        /// <summary>
        /// 301/302 回源自动跟随配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// 自定义错误页面配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// 自定义请求头部配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeader")]
        public RequestHeader RequestHeader{ get; set; }

        /// <summary>
        /// 自定义响应头部配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// 单链接下行限速配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownstreamCapping")]
        public DownstreamCapping DownstreamCapping{ get; set; }

        /// <summary>
        /// 带参/不带参缓存配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// 源站头部缓存配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseHeaderCache")]
        public ResponseHeaderCache ResponseHeaderCache{ get; set; }

        /// <summary>
        /// 视频拖拽配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoSeek")]
        public VideoSeek VideoSeek{ get; set; }

        /// <summary>
        /// 节点缓存过期规则配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// 跨国链路优化配置（功能灰度中，敬请期待）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullOptimization")]
        public OriginPullOptimization OriginPullOptimization{ get; set; }

        /// <summary>
        /// Https 加速相关配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// 时间戳防盗链配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// SEO 优化配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seo")]
        public Seo Seo{ get; set; }

        /// <summary>
        /// 域名封禁状态
        /// normal：正常状态
        /// overdue：账号欠费导致域名关闭，充值完成后可自行启动加速服务
        /// malicious：域名出现恶意行为，强制关闭加速服务
        /// ddos：域名被大规模 DDoS 攻击，关闭加速服务
        /// idle：域名超过 90 天内无任何操作、数据产生，判定为不活跃域名自动关闭加速服务，可自行启动加速服务
        /// unlicensed：域名未备案/备案注销，自动关闭加速服务，备案完成后可自行启动加速服务
        /// capping：触发配置的带宽阈值上限
        /// readonly：域名存在特殊配置，被锁定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// 访问协议强制跳转配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Referer 防盗链配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// 浏览器缓存过期规则配置（功能灰度中，敬请期待）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// Ipv6 回源配置（功能灰度中，敬请期待）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// 是否兼容旧版本配置（内部兼容性字段）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compatibility")]
        public Compatibility Compatibility{ get; set; }

        /// <summary>
        /// 区域特殊配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecificConfig")]
        public SpecificConfig SpecificConfig{ get; set; }

        /// <summary>
        /// 加速区域
        /// mainland：中国境内加速
        /// overseas：中国境外加速
        /// global：全球加速
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 域名锁定状态
        /// normal：未锁定
        /// mainland：中国境内锁定
        /// overseas：中国境外锁定
        /// global：全球锁定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }

        /// <summary>
        /// 回源超时配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullTimeout")]
        public OriginPullTimeout OriginPullTimeout{ get; set; }

        /// <summary>
        /// 回源S3鉴权配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AwsPrivateAccess")]
        public AwsPrivateAccess AwsPrivateAccess{ get; set; }

        /// <summary>
        /// Scdn配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityConfig")]
        public SecurityConfig SecurityConfig{ get; set; }

        /// <summary>
        /// ImageOptimization配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageOptimization")]
        public ImageOptimization ImageOptimization{ get; set; }

        /// <summary>
        /// UA黑白名单配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAgentFilter")]
        public UserAgentFilter UserAgentFilter{ get; set; }

        /// <summary>
        /// 访问控制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessControl")]
        public AccessControl AccessControl{ get; set; }

        /// <summary>
        /// 是否支持高级配置项
        /// on：支持
        /// off：不支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Advance")]
        public string Advance{ get; set; }

        /// <summary>
        /// URL重定向配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlRedirect")]
        public UrlRedirect UrlRedirect{ get; set; }

        /// <summary>
        /// 访问端口配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessPort")]
        public long?[] AccessPort{ get; set; }

        /// <summary>
        /// 标签配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级配置，白名单功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvancedAuthentication")]
        public AdvancedAuthentication AdvancedAuthentication{ get; set; }

        /// <summary>
        /// 回源鉴权高级配置，白名单功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginAuthentication")]
        public OriginAuthentication OriginAuthentication{ get; set; }

        /// <summary>
        /// Ipv6访问配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv6Access")]
        public Ipv6Access Ipv6Access{ get; set; }

        /// <summary>
        /// 高级配置集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvanceSet")]
        public AdvanceConfig[] AdvanceSet{ get; set; }

        /// <summary>
        /// 离线缓存（功能灰度中，尚未全量，请等待后续全量发布）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// 合并回源（白名单功能）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginCombine")]
        public OriginCombine OriginCombine{ get; set; }

        /// <summary>
        /// POST上传配置项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostSize PostMaxSize{ get; set; }

        /// <summary>
        /// Quic配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// 回源OSS私有鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OssPrivateAccess")]
        public OssPrivateAccess OssPrivateAccess{ get; set; }

        /// <summary>
        /// WebSocket配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// 远程鉴权配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteAuthentication")]
        public RemoteAuthentication RemoteAuthentication{ get; set; }

        /// <summary>
        /// 共享CNAME配置（白名单功能）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareCname")]
        public ShareCname ShareCname{ get; set; }

        /// <summary>
        /// 规则引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleEngine")]
        public RuleEngine RuleEngine{ get; set; }

        /// <summary>
        /// 主域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentHost")]
        public string ParentHost{ get; set; }

        /// <summary>
        /// 华为云对象存储回源鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HwPrivateAccess")]
        public HwPrivateAccess HwPrivateAccess{ get; set; }

        /// <summary>
        /// 七牛云对象存储回源鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QnPrivateAccess")]
        public QnPrivateAccess QnPrivateAccess{ get; set; }

        /// <summary>
        /// HTTPS服务，缺省时默认开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpsBilling")]
        public HttpsBilling HttpsBilling{ get; set; }

        /// <summary>
        /// 其他厂商对象存储回源鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OthersPrivateAccess")]
        public OthersPrivateAccess OthersPrivateAccess{ get; set; }

        /// <summary>
        /// 参数黑名单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamFilter")]
        public ParamFilter ParamFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "StatusCodeCache.", this.StatusCodeCache);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "BandwidthAlert.", this.BandwidthAlert);
            this.SetParamObj(map, prefix + "RangeOriginPull.", this.RangeOriginPull);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "DownstreamCapping.", this.DownstreamCapping);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "ResponseHeaderCache.", this.ResponseHeaderCache);
            this.SetParamObj(map, prefix + "VideoSeek.", this.VideoSeek);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "OriginPullOptimization.", this.OriginPullOptimization);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "Seo.", this.Seo);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "Compatibility.", this.Compatibility);
            this.SetParamObj(map, prefix + "SpecificConfig.", this.SpecificConfig);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
            this.SetParamObj(map, prefix + "OriginPullTimeout.", this.OriginPullTimeout);
            this.SetParamObj(map, prefix + "AwsPrivateAccess.", this.AwsPrivateAccess);
            this.SetParamObj(map, prefix + "SecurityConfig.", this.SecurityConfig);
            this.SetParamObj(map, prefix + "ImageOptimization.", this.ImageOptimization);
            this.SetParamObj(map, prefix + "UserAgentFilter.", this.UserAgentFilter);
            this.SetParamObj(map, prefix + "AccessControl.", this.AccessControl);
            this.SetParamSimple(map, prefix + "Advance", this.Advance);
            this.SetParamObj(map, prefix + "UrlRedirect.", this.UrlRedirect);
            this.SetParamArraySimple(map, prefix + "AccessPort.", this.AccessPort);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "AdvancedAuthentication.", this.AdvancedAuthentication);
            this.SetParamObj(map, prefix + "OriginAuthentication.", this.OriginAuthentication);
            this.SetParamObj(map, prefix + "Ipv6Access.", this.Ipv6Access);
            this.SetParamArrayObj(map, prefix + "AdvanceSet.", this.AdvanceSet);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "OriginCombine.", this.OriginCombine);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "OssPrivateAccess.", this.OssPrivateAccess);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "RemoteAuthentication.", this.RemoteAuthentication);
            this.SetParamObj(map, prefix + "ShareCname.", this.ShareCname);
            this.SetParamObj(map, prefix + "RuleEngine.", this.RuleEngine);
            this.SetParamSimple(map, prefix + "ParentHost", this.ParentHost);
            this.SetParamObj(map, prefix + "HwPrivateAccess.", this.HwPrivateAccess);
            this.SetParamObj(map, prefix + "QnPrivateAccess.", this.QnPrivateAccess);
            this.SetParamObj(map, prefix + "HttpsBilling.", this.HttpsBilling);
            this.SetParamObj(map, prefix + "OthersPrivateAccess.", this.OthersPrivateAccess);
            this.SetParamObj(map, prefix + "ParamFilter.", this.ParamFilter);
        }
    }
}

