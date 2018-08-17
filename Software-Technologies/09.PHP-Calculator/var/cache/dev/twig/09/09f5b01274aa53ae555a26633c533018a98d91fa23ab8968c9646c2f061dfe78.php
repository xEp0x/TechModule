<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_c73fc262934ff685a2bd13265c8862d35c8e717fde36196435c83d2f9f7a6d1a extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6ba223f762f7923d1ff2d15f49693c2d2089088f190f8a78ef875a7982dcbd53 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6ba223f762f7923d1ff2d15f49693c2d2089088f190f8a78ef875a7982dcbd53->enter($__internal_6ba223f762f7923d1ff2d15f49693c2d2089088f190f8a78ef875a7982dcbd53_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6ba223f762f7923d1ff2d15f49693c2d2089088f190f8a78ef875a7982dcbd53->leave($__internal_6ba223f762f7923d1ff2d15f49693c2d2089088f190f8a78ef875a7982dcbd53_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_6cb820554c303c50f89d6b02936ef35c1edc24dab0755147da752eede0e999ce = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6cb820554c303c50f89d6b02936ef35c1edc24dab0755147da752eede0e999ce->enter($__internal_6cb820554c303c50f89d6b02936ef35c1edc24dab0755147da752eede0e999ce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_6cb820554c303c50f89d6b02936ef35c1edc24dab0755147da752eede0e999ce->leave($__internal_6cb820554c303c50f89d6b02936ef35c1edc24dab0755147da752eede0e999ce_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_fc060d5daec7335daf6fd5ae8c27006e08e5e6f3d205ffcd8168caefeb80f94b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fc060d5daec7335daf6fd5ae8c27006e08e5e6f3d205ffcd8168caefeb80f94b->enter($__internal_fc060d5daec7335daf6fd5ae8c27006e08e5e6f3d205ffcd8168caefeb80f94b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_fc060d5daec7335daf6fd5ae8c27006e08e5e6f3d205ffcd8168caefeb80f94b->leave($__internal_fc060d5daec7335daf6fd5ae8c27006e08e5e6f3d205ffcd8168caefeb80f94b_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_29f3a85b19f4e3fa06809041b0496b3619e1f00d3ccdd4550e84403226e2d8f6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_29f3a85b19f4e3fa06809041b0496b3619e1f00d3ccdd4550e84403226e2d8f6->enter($__internal_29f3a85b19f4e3fa06809041b0496b3619e1f00d3ccdd4550e84403226e2d8f6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_29f3a85b19f4e3fa06809041b0496b3619e1f00d3ccdd4550e84403226e2d8f6->leave($__internal_29f3a85b19f4e3fa06809041b0496b3619e1f00d3ccdd4550e84403226e2d8f6_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
