<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_6f9cd8932e44dea70f1810224e04d5d470150d81add0c913a02002847461263e extends Twig_Template
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
        $__internal_149fc8323e4ca9933ec8eec4d40751982f011b7a5f7f74f44d253809b070fcc9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_149fc8323e4ca9933ec8eec4d40751982f011b7a5f7f74f44d253809b070fcc9->enter($__internal_149fc8323e4ca9933ec8eec4d40751982f011b7a5f7f74f44d253809b070fcc9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_149fc8323e4ca9933ec8eec4d40751982f011b7a5f7f74f44d253809b070fcc9->leave($__internal_149fc8323e4ca9933ec8eec4d40751982f011b7a5f7f74f44d253809b070fcc9_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_b855b1ce75a1e3294df70be9266f5b34aca3df6e63489ffa2c9e9c7c1c3518ac = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b855b1ce75a1e3294df70be9266f5b34aca3df6e63489ffa2c9e9c7c1c3518ac->enter($__internal_b855b1ce75a1e3294df70be9266f5b34aca3df6e63489ffa2c9e9c7c1c3518ac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_b855b1ce75a1e3294df70be9266f5b34aca3df6e63489ffa2c9e9c7c1c3518ac->leave($__internal_b855b1ce75a1e3294df70be9266f5b34aca3df6e63489ffa2c9e9c7c1c3518ac_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_6ebb1e314684cd365c42d7caa26f451242f2bea08d76fdf5cebb7da6b57f548b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6ebb1e314684cd365c42d7caa26f451242f2bea08d76fdf5cebb7da6b57f548b->enter($__internal_6ebb1e314684cd365c42d7caa26f451242f2bea08d76fdf5cebb7da6b57f548b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_6ebb1e314684cd365c42d7caa26f451242f2bea08d76fdf5cebb7da6b57f548b->leave($__internal_6ebb1e314684cd365c42d7caa26f451242f2bea08d76fdf5cebb7da6b57f548b_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_168d1cf24a6240fd15a05950326598381fe4ae6db154f3c99af1ffd7a56f1ebc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_168d1cf24a6240fd15a05950326598381fe4ae6db154f3c99af1ffd7a56f1ebc->enter($__internal_168d1cf24a6240fd15a05950326598381fe4ae6db154f3c99af1ffd7a56f1ebc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_168d1cf24a6240fd15a05950326598381fe4ae6db154f3c99af1ffd7a56f1ebc->leave($__internal_168d1cf24a6240fd15a05950326598381fe4ae6db154f3c99af1ffd7a56f1ebc_prof);

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
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

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
";
    }
}
