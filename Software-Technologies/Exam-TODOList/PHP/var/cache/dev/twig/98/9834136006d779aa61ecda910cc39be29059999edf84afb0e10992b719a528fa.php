<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_93d9a3c6ffabc2ae174b630038438cba0cad7a3171ee7be8385e54d201411f21 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_93d9a3c6ffabc2ae174b630038438cba0cad7a3171ee7be8385e54d201411f21->enter($__internal_93d9a3c6ffabc2ae174b630038438cba0cad7a3171ee7be8385e54d201411f21_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_358ea1bb505c8e4874f877701edf43a9ba8ef5622f79bd19b07aeb4a88367a6f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_358ea1bb505c8e4874f877701edf43a9ba8ef5622f79bd19b07aeb4a88367a6f->enter($__internal_358ea1bb505c8e4874f877701edf43a9ba8ef5622f79bd19b07aeb4a88367a6f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_93d9a3c6ffabc2ae174b630038438cba0cad7a3171ee7be8385e54d201411f21->leave($__internal_93d9a3c6ffabc2ae174b630038438cba0cad7a3171ee7be8385e54d201411f21_prof);

        
        $__internal_358ea1bb505c8e4874f877701edf43a9ba8ef5622f79bd19b07aeb4a88367a6f->leave($__internal_358ea1bb505c8e4874f877701edf43a9ba8ef5622f79bd19b07aeb4a88367a6f_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_738a1a7abbfb70d3cecac41186b70b3a444ded99b26bd36f6f35e3f795175c12 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_738a1a7abbfb70d3cecac41186b70b3a444ded99b26bd36f6f35e3f795175c12->enter($__internal_738a1a7abbfb70d3cecac41186b70b3a444ded99b26bd36f6f35e3f795175c12_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_b7c31973e19a98d2be8c8aca08fc01cb08e4a8c2582f6642b35256ccb4794af6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b7c31973e19a98d2be8c8aca08fc01cb08e4a8c2582f6642b35256ccb4794af6->enter($__internal_b7c31973e19a98d2be8c8aca08fc01cb08e4a8c2582f6642b35256ccb4794af6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_b7c31973e19a98d2be8c8aca08fc01cb08e4a8c2582f6642b35256ccb4794af6->leave($__internal_b7c31973e19a98d2be8c8aca08fc01cb08e4a8c2582f6642b35256ccb4794af6_prof);

        
        $__internal_738a1a7abbfb70d3cecac41186b70b3a444ded99b26bd36f6f35e3f795175c12->leave($__internal_738a1a7abbfb70d3cecac41186b70b3a444ded99b26bd36f6f35e3f795175c12_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_3601450a7edb3415bbc5fc38af229e6e97e2701f14f9d4dc137bb14ea86f1dcb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3601450a7edb3415bbc5fc38af229e6e97e2701f14f9d4dc137bb14ea86f1dcb->enter($__internal_3601450a7edb3415bbc5fc38af229e6e97e2701f14f9d4dc137bb14ea86f1dcb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_68c09e3bc8cacf43a4775de85af3401b8d30d6d260035c1edda3c942395a47ff = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_68c09e3bc8cacf43a4775de85af3401b8d30d6d260035c1edda3c942395a47ff->enter($__internal_68c09e3bc8cacf43a4775de85af3401b8d30d6d260035c1edda3c942395a47ff_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_68c09e3bc8cacf43a4775de85af3401b8d30d6d260035c1edda3c942395a47ff->leave($__internal_68c09e3bc8cacf43a4775de85af3401b8d30d6d260035c1edda3c942395a47ff_prof);

        
        $__internal_3601450a7edb3415bbc5fc38af229e6e97e2701f14f9d4dc137bb14ea86f1dcb->leave($__internal_3601450a7edb3415bbc5fc38af229e6e97e2701f14f9d4dc137bb14ea86f1dcb_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_4d6dce8f40fb9268f5721f8ae7e8feeaebd288fe8822580d540615db7823b890 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4d6dce8f40fb9268f5721f8ae7e8feeaebd288fe8822580d540615db7823b890->enter($__internal_4d6dce8f40fb9268f5721f8ae7e8feeaebd288fe8822580d540615db7823b890_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_c8d156ae97c00aa54a65eec50f8f153c4230d5614b222d5f1934e2a0aab70b44 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c8d156ae97c00aa54a65eec50f8f153c4230d5614b222d5f1934e2a0aab70b44->enter($__internal_c8d156ae97c00aa54a65eec50f8f153c4230d5614b222d5f1934e2a0aab70b44_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_c8d156ae97c00aa54a65eec50f8f153c4230d5614b222d5f1934e2a0aab70b44->leave($__internal_c8d156ae97c00aa54a65eec50f8f153c4230d5614b222d5f1934e2a0aab70b44_prof);

        
        $__internal_4d6dce8f40fb9268f5721f8ae7e8feeaebd288fe8822580d540615db7823b890->leave($__internal_4d6dce8f40fb9268f5721f8ae7e8feeaebd288fe8822580d540615db7823b890_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
