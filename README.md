# NTLM-REST
See "RAW" view 
<proxy xmlns="http://ws.apache.org/ns/synapse"
       name="NTLMProxyGET"
       transports="https,http"
       statistics="disable"
       trace="disable"
       startOnLoad="true">
   <target>
      <inSequence>
         <log/>
         <property name="messageType" value="application/json" scope="axis2"/>
         <property name="enableREST"
                   value="true"
                   scope="axis2-client"
                   type="BOOLEAN"/>
         <class name="org.wso2.carbon.mediator.ntlm.NTLMMediator">
            <property name="username" value="dushan"/>
            <property name="host" value="192.168.59.103"/>
            <property name="domain" value="dushan"/>
            <property name="password" value="hm"/>
         </class>
         <property name="HTTP_METHOD" value="GET" scope="axis2" type="STRING"/>
         <class name="org.wso2.carbon.mediator.ntlm.NTLMCalloutMediator">
            <property name="serviceURL"
                      value="http://192.168.59.103/RestService2/RestServiceImpl.svc/xml/1"/>
            <property name="initAxis2ClientOptions" value="false"/>
         </class>
         <header name="To" action="remove"/>
         <property name="RESPONSE" value="true" scope="default" type="STRING"/>
         <property name="NO_ENTITY_BODY" scope="axis2" action="remove"/>
         <send/>
      </inSequence>
   </target>
   <description/>
</proxy>
          
          
 <proxy xmlns="http://ws.apache.org/ns/synapse"
       name="NTLMProxyPOST"
       transports="https,http"
       statistics="disable"
       trace="disable"
       startOnLoad="true">
   <target>
      <inSequence>
         <log/>
         <property name="messageType" value="application/json" scope="axis2"/>
         <property name="enableREST"
                   value="true"
                   scope="axis2-client"
                   type="BOOLEAN"/>
         <class name="org.wso2.carbon.mediator.ntlm.NTLMMediator">
            <property name="username" value="dushan"/>
            <property name="host" value="192.168.59.103"/>
            <property name="domain" value="dushan"/>
            <property name="password" value="hm"/>
         </class>
         <property name="HTTP_METHOD" value="POST" scope="axis2" type="STRING"/>
         <class name="org.wso2.carbon.mediator.ntlm.NTLMCalloutMediator">
            <property name="serviceURL"
                      value="http://192.168.59.103/RestService2/RestServiceImpl.svc/auth"/>
            <property name="initAxis2ClientOptions" value="false"/>
         </class>
         <header name="To" action="remove"/>
         <property name="RESPONSE" value="true" scope="default" type="STRING"/>
         <property name="NO_ENTITY_BODY" scope="axis2" action="remove"/>
         <send/>
      </inSequence>
   </target>
   <description/>
</proxy>
                                
